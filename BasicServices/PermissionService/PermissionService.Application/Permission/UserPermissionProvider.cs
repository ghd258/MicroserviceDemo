﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using CommonLibrary;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Npgsql;
using PermissionService.Domain;
using PermissionService.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PermissionService.Application
{

    public class GetRoleAssignmentsRequest : IRequest<List<RoleAssignmentModel>>
    {
    }

    public class GetRoleAssignmentslHandler : IRequestHandler<GetRoleAssignmentsRequest, List<RoleAssignmentModel>>
    {
        private readonly PermissionDBReadOnlyContext dbContext;
        private readonly IMapper autoMapper;
        private readonly UserInfo currentUserInfo;
        public GetRoleAssignmentslHandler(PermissionDBReadOnlyContext _dbContext, IMapper _autoMapper, IHttpContextAccessor _httpContextAccessor)
        {
            dbContext = _dbContext;
            autoMapper = _autoMapper;
            currentUserInfo = _httpContextAccessor.HttpContext.Items["CurrentUserInfo"] as UserInfo;
        }

        public async Task<List<RoleAssignmentModel>> Handle(GetRoleAssignmentsRequest request, CancellationToken cancellationToken)
        {
            var query = dbContext.RoleAssignments.Where(p => p.Principal.PrincipalCode == currentUserInfo.UserCode).OrderBy(p => p.Role.SortNO);
            List<RoleAssignmentModel> roleAssignmentModels = await query.ProjectTo<RoleAssignmentModel>(autoMapper.ConfigurationProvider).ToListAsync(cancellationToken);
            return roleAssignmentModels;
        }
    }

    public class GetUserPermissionRequest : IRequest<UserPermission>
    {
        public Guid RoleAssignmentID { get; set; }
    }

    public class GetUserPermissionHandler : IRequestHandler<GetUserPermissionRequest, UserPermission>
    {
        private readonly PermissionDBReadOnlyContext dbContext;
        private readonly IMapper autoMapper;
        private readonly UserInfo currentUserInfo;
        private readonly IUserPermissionCache userPermissionCache;
        public GetUserPermissionHandler(PermissionDBReadOnlyContext _dbContext, IMapper _autoMapper, IHttpContextAccessor _httpContextAccessor, IUserPermissionCache _userPermissionCache)
        {
            dbContext = _dbContext;
            autoMapper = _autoMapper;
            currentUserInfo = _httpContextAccessor.HttpContext.Items["CurrentUserInfo"] as UserInfo;
            userPermissionCache = _userPermissionCache;
        }

        public async Task<UserPermission> Handle(GetUserPermissionRequest request, CancellationToken cancellationToken)
        {
            RoleAssignment roleAssignment;
            if (request.RoleAssignmentID == Guid.Empty)
            {
                roleAssignment = dbContext.RoleAssignments.Include(p => p.Role).Include(p => p.Scope)
                    .Where(p => p.Principal.PrincipalCode == currentUserInfo.UserCode).OrderBy(p => p.Role.SortNO).First();
            }
            else
            {
                roleAssignment = dbContext.RoleAssignments.Include(p => p.Role).Include(p => p.Scope)
                    .Where(p => p.ID == request.RoleAssignmentID).First();
            }
            if (roleAssignment == null)
            {
                throw new FriendlyException()
                {
                    ExceptionCode = (int)HttpStatusCode.NotFound,
                    ExceptionMessage = $"The RoleAssignment id: {request.RoleAssignmentID} does not exist."
                };
            }
            UserPermission currentUserPermission = new UserPermission();
            currentUserPermission.RoleCode = roleAssignment.Role.RoleCode;
            currentUserPermission.AllowResourceCodes = dbContext.RolePermissions.Where(p => p.Role.ID == roleAssignment.RoleID).Select(p => p.ResourceCode).ToList();
            currentUserPermission.ScopeCode = roleAssignment.Scope.ScopeCode;
            currentUserPermission.AllowScopeCodes = dbContext.Scopes.Where(p => p.ScopeCode.StartsWith(roleAssignment.Scope.ScopeCode)).Select(p => p.ScopeCode).ToList();

            await userPermissionCache.SetCurrentUserPermission(currentUserPermission);

            return currentUserPermission;

        }
    }

}
