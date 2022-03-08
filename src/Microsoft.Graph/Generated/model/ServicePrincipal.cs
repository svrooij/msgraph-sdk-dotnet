// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Service Principal.
    /// </summary>
    public partial class ServicePrincipal : DirectoryObject
    {
    
        ///<summary>
        /// The ServicePrincipal constructor
        ///</summary>
        public ServicePrincipal()
        {
            this.ODataType = "microsoft.graph.servicePrincipal";
        }

        /// <summary>
        /// Gets or sets account enabled.
        /// true if the service principal account is enabled; otherwise, false. Supports $filter (eq, ne, not, in).
        /// </summary>
        [JsonPropertyName("accountEnabled")]
        public bool? AccountEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets add ins.
        /// Defines custom behavior that a consuming service can use to call an app in specific contexts. For example, applications that can render file streams may set the addIns property for its 'FileHandler' functionality. This will let services like Microsoft 365 call the application in the context of a document the user is working on.
        /// </summary>
        [JsonPropertyName("addIns")]
        public IEnumerable<AddIn> AddIns { get; set; }
    
        /// <summary>
        /// Gets or sets alternative names.
        /// Used to retrieve service principals by subscription, identify resource group and full resource ids for managed identities. Supports $filter (eq, not, ge, le, startsWith).
        /// </summary>
        [JsonPropertyName("alternativeNames")]
        public IEnumerable<string> AlternativeNames { get; set; }
    
        /// <summary>
        /// Gets or sets app description.
        /// The description exposed by the associated application.
        /// </summary>
        [JsonPropertyName("appDescription")]
        public string AppDescription { get; set; }
    
        /// <summary>
        /// Gets or sets app display name.
        /// The display name exposed by the associated application.
        /// </summary>
        [JsonPropertyName("appDisplayName")]
        public string AppDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets app id.
        /// The unique identifier for the associated application (its appId property). Supports $filter (eq, ne, not, in, startsWith).
        /// </summary>
        [JsonPropertyName("appId")]
        public string AppId { get; set; }
    
        /// <summary>
        /// Gets or sets application template id.
        /// Unique identifier of the applicationTemplate that the servicePrincipal was created from. Read-only. Supports $filter (eq, ne, NOT, startsWith).
        /// </summary>
        [JsonPropertyName("applicationTemplateId")]
        public string ApplicationTemplateId { get; set; }
    
        /// <summary>
        /// Gets or sets app owner organization id.
        /// Contains the tenant id where the application is registered. This is applicable only to service principals backed by applications. Supports $filter (eq, ne, NOT, ge, le).
        /// </summary>
        [JsonPropertyName("appOwnerOrganizationId")]
        public Guid? AppOwnerOrganizationId { get; set; }
    
        /// <summary>
        /// Gets or sets app role assignment required.
        /// Specifies whether users or other service principals need to be granted an app role assignment for this service principal before users can sign in or apps can get tokens. The default value is false. Not nullable. Supports $filter (eq, ne, NOT).
        /// </summary>
        [JsonPropertyName("appRoleAssignmentRequired")]
        public bool? AppRoleAssignmentRequired { get; set; }
    
        /// <summary>
        /// Gets or sets app roles.
        /// The roles exposed by the application which this service principal represents. For more information see the appRoles property definition on the application entity. Not nullable.
        /// </summary>
        [JsonPropertyName("appRoles")]
        public IEnumerable<AppRole> AppRoles { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Free text field to provide an internal end-user facing description of the service principal. End-user portals such MyApps will display the application description in this field. The maximum allowed size is 1024 characters. Supports $filter (eq, ne, not, ge, le, startsWith) and $search.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets disabled by microsoft status.
        /// Specifies whether Microsoft has disabled the registered application. Possible values are: null (default value), NotDisabled, and DisabledDueToViolationOfServicesAgreement (reasons may include suspicious, abusive, or malicious activity, or a violation of the Microsoft Services Agreement).  Supports $filter (eq, ne, not).
        /// </summary>
        [JsonPropertyName("disabledByMicrosoftStatus")]
        public string DisabledByMicrosoftStatus { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name for the service principal. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderBy.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets homepage.
        /// Home page or landing page of the application.
        /// </summary>
        [JsonPropertyName("homepage")]
        public string Homepage { get; set; }
    
        /// <summary>
        /// Gets or sets info.
        /// Basic profile information of the acquired application such as app's marketing, support, terms of service and privacy statement URLs. The terms of service and privacy statement are surfaced to users through the user consent experience. For more info, see How to: Add Terms of service and privacy statement for registered Azure AD apps. Supports $filter (eq, ne, not, ge, le, and eq on null values).
        /// </summary>
        [JsonPropertyName("info")]
        public InformationalUrl Info { get; set; }
    
        /// <summary>
        /// Gets or sets key credentials.
        /// The collection of key credentials associated with the service principal. Not nullable. Supports $filter (eq, not, ge, le).
        /// </summary>
        [JsonPropertyName("keyCredentials")]
        public IEnumerable<KeyCredential> KeyCredentials { get; set; }
    
        /// <summary>
        /// Gets or sets login url.
        /// Specifies the URL where the service provider redirects the user to Azure AD to authenticate. Azure AD uses the URL to launch the application from Microsoft 365 or the Azure AD My Apps. When blank, Azure AD performs IdP-initiated sign-on for applications configured with SAML-based single sign-on. The user launches the application from Microsoft 365, the Azure AD My Apps, or the Azure AD SSO URL.
        /// </summary>
        [JsonPropertyName("loginUrl")]
        public string LoginUrl { get; set; }
    
        /// <summary>
        /// Gets or sets logout url.
        /// Specifies the URL that will be used by Microsoft's authorization service to logout an user using OpenId Connect front-channel, back-channel or SAML logout protocols.
        /// </summary>
        [JsonPropertyName("logoutUrl")]
        public string LogoutUrl { get; set; }
    
        /// <summary>
        /// Gets or sets notes.
        /// Free text field to capture information about the service principal, typically used for operational purposes. Maximum allowed size is 1024 characters.
        /// </summary>
        [JsonPropertyName("notes")]
        public string Notes { get; set; }
    
        /// <summary>
        /// Gets or sets notification email addresses.
        /// Specifies the list of email addresses where Azure AD sends a notification when the active certificate is near the expiration date. This is only for the certificates used to sign the SAML token issued for Azure AD Gallery applications.
        /// </summary>
        [JsonPropertyName("notificationEmailAddresses")]
        public IEnumerable<string> NotificationEmailAddresses { get; set; }
    
        /// <summary>
        /// Gets or sets oauth2permission scopes.
        /// The delegated permissions exposed by the application. For more information see the oauth2PermissionScopes property on the application entity's api property. Not nullable.
        /// </summary>
        [JsonPropertyName("oauth2PermissionScopes")]
        public IEnumerable<PermissionScope> Oauth2PermissionScopes { get; set; }
    
        /// <summary>
        /// Gets or sets password credentials.
        /// The collection of password credentials associated with the application. Not nullable.
        /// </summary>
        [JsonPropertyName("passwordCredentials")]
        public IEnumerable<PasswordCredential> PasswordCredentials { get; set; }
    
        /// <summary>
        /// Gets or sets preferred single sign on mode.
        /// Specifies the single sign-on mode configured for this application. Azure AD uses the preferred single sign-on mode to launch the application from Microsoft 365 or the Azure AD My Apps. The supported values are password, saml, notSupported, and oidc.
        /// </summary>
        [JsonPropertyName("preferredSingleSignOnMode")]
        public string PreferredSingleSignOnMode { get; set; }
    
        /// <summary>
        /// Gets or sets preferred token signing key thumbprint.
        /// Reserved for internal use only. Do not write or otherwise rely on this property. May be removed in future versions.
        /// </summary>
        [JsonPropertyName("preferredTokenSigningKeyThumbprint")]
        public string PreferredTokenSigningKeyThumbprint { get; set; }
    
        /// <summary>
        /// Gets or sets reply urls.
        /// The URLs that user tokens are sent to for sign in with the associated application, or the redirect URIs that OAuth 2.0 authorization codes and access tokens are sent to for the associated application. Not nullable.
        /// </summary>
        [JsonPropertyName("replyUrls")]
        public IEnumerable<string> ReplyUrls { get; set; }
    
        /// <summary>
        /// Gets or sets resource specific application permissions.
        /// The resource-specific application permissions exposed by this application. Currently, resource-specific permissions are only supported for Teams apps accessing to specific chats and teams using Microsoft Graph. Read-only.
        /// </summary>
        [JsonPropertyName("resourceSpecificApplicationPermissions")]
        public IEnumerable<ResourceSpecificPermission> ResourceSpecificApplicationPermissions { get; set; }
    
        /// <summary>
        /// Gets or sets saml single sign on settings.
        /// The collection for settings related to saml single sign-on.
        /// </summary>
        [JsonPropertyName("samlSingleSignOnSettings")]
        public SamlSingleSignOnSettings SamlSingleSignOnSettings { get; set; }
    
        /// <summary>
        /// Gets or sets service principal names.
        /// Contains the list of identifiersUris, copied over from the associated application. Additional values can be added to hybrid applications. These values can be used to identify the permissions exposed by this app within Azure AD. For example,Client apps can specify a resource URI which is based on the values of this property to acquire an access token, which is the URI returned in the 'aud' claim.The any operator is required for filter expressions on multi-valued properties. Not nullable.  Supports $filter (eq, not, ge, le, startsWith).
        /// </summary>
        [JsonPropertyName("servicePrincipalNames")]
        public IEnumerable<string> ServicePrincipalNames { get; set; }
    
        /// <summary>
        /// Gets or sets service principal type.
        /// Identifies whether the service principal represents an application, a managed identity, or a legacy application. This is set by Azure AD internally. The servicePrincipalType property can be set to three different values: __Application - A service principal that represents an application or service. The appId property identifies the associated app registration, and matches the appId of an application, possibly from a different tenant. If the associated app registration is missing, tokens are not issued for the service principal.__ManagedIdentity - A service principal that represents a managed identity. Service principals representing managed identities can be granted access and permissions, but cannot be updated or modified directly.__Legacy - A service principal that represents an app created before app registrations, or through legacy experiences. Legacy service principal can have credentials, service principal names, reply URLs, and other properties which are editable by an authorized user, but does not have an associated app registration. The appId value does not associate the service principal with an app registration. The service principal can only be used in the tenant where it was created.__SocialIdp - For internal use.
        /// </summary>
        [JsonPropertyName("servicePrincipalType")]
        public string ServicePrincipalType { get; set; }
    
        /// <summary>
        /// Gets or sets sign in audience.
        /// Specifies the Microsoft accounts that are supported for the current application. Read-only. Supported values are:AzureADMyOrg: Users with a Microsoft work or school account in my organization’s Azure AD tenant (single-tenant).AzureADMultipleOrgs: Users with a Microsoft work or school account in any organization’s Azure AD tenant (multi-tenant).AzureADandPersonalMicrosoftAccount: Users with a personal Microsoft account, or a work or school account in any organization’s Azure AD tenant.PersonalMicrosoftAccount: Users with a personal Microsoft account only.
        /// </summary>
        [JsonPropertyName("signInAudience")]
        public string SignInAudience { get; set; }
    
        /// <summary>
        /// Gets or sets tags.
        /// Custom strings that can be used to categorize and identify the service principal. Not nullable. Supports $filter (eq, not, ge, le, startsWith).
        /// </summary>
        [JsonPropertyName("tags")]
        public IEnumerable<string> Tags { get; set; }
    
        /// <summary>
        /// Gets or sets token encryption key id.
        /// Specifies the keyId of a public key from the keyCredentials collection. When configured, Azure AD issues tokens for this application encrypted using the key specified by this property. The application code that receives the encrypted token must use the matching private key to decrypt the token before it can be used for the signed-in user.
        /// </summary>
        [JsonPropertyName("tokenEncryptionKeyId")]
        public Guid? TokenEncryptionKeyId { get; set; }
    
        /// <summary>
        /// Gets or sets app role assigned to.
        /// App role assignments for this app or service, granted to users, groups, and other service principals. Supports $expand.
        /// </summary>
        [JsonPropertyName("appRoleAssignedTo")]
        public IServicePrincipalAppRoleAssignedToCollectionPage AppRoleAssignedTo { get; set; }

        /// <summary>
        /// Gets or sets appRoleAssignedToNextLink.
        /// </summary>
        [JsonPropertyName("appRoleAssignedTo@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AppRoleAssignedToNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets app role assignments.
        /// App role assignment for another app or service, granted to this service principal. Supports $expand.
        /// </summary>
        [JsonPropertyName("appRoleAssignments")]
        public IServicePrincipalAppRoleAssignmentsCollectionPage AppRoleAssignments { get; set; }

        /// <summary>
        /// Gets or sets appRoleAssignmentsNextLink.
        /// </summary>
        [JsonPropertyName("appRoleAssignments@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AppRoleAssignmentsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets claims mapping policies.
        /// The claimsMappingPolicies assigned to this service principal. Supports $expand.
        /// </summary>
        [JsonPropertyName("claimsMappingPolicies")]
        public IServicePrincipalClaimsMappingPoliciesCollectionWithReferencesPage ClaimsMappingPolicies { get; set; }

        /// <summary>
        /// Gets or sets claimsMappingPoliciesNextLink.
        /// </summary>
        [JsonPropertyName("claimsMappingPolicies@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ClaimsMappingPoliciesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets created objects.
        /// Directory objects created by this service principal. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("createdObjects")]
        public IServicePrincipalCreatedObjectsCollectionWithReferencesPage CreatedObjects { get; set; }

        /// <summary>
        /// Gets or sets createdObjectsNextLink.
        /// </summary>
        [JsonPropertyName("createdObjects@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string CreatedObjectsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets delegated permission classifications.
        /// The permission classifications for delegated permissions exposed by the app that this service principal represents. Supports $expand.
        /// </summary>
        [JsonPropertyName("delegatedPermissionClassifications")]
        public IServicePrincipalDelegatedPermissionClassificationsCollectionPage DelegatedPermissionClassifications { get; set; }

        /// <summary>
        /// Gets or sets delegatedPermissionClassificationsNextLink.
        /// </summary>
        [JsonPropertyName("delegatedPermissionClassifications@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string DelegatedPermissionClassificationsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets endpoints.
        /// Endpoints available for discovery. Services like Sharepoint populate this property with a tenant specific SharePoint endpoints that other applications can discover and use in their experiences.
        /// </summary>
        [JsonPropertyName("endpoints")]
        public IServicePrincipalEndpointsCollectionPage Endpoints { get; set; }

        /// <summary>
        /// Gets or sets endpointsNextLink.
        /// </summary>
        [JsonPropertyName("endpoints@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string EndpointsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets home realm discovery policies.
        /// The homeRealmDiscoveryPolicies assigned to this service principal. Supports $expand.
        /// </summary>
        [JsonPropertyName("homeRealmDiscoveryPolicies")]
        public IServicePrincipalHomeRealmDiscoveryPoliciesCollectionWithReferencesPage HomeRealmDiscoveryPolicies { get; set; }

        /// <summary>
        /// Gets or sets homeRealmDiscoveryPoliciesNextLink.
        /// </summary>
        [JsonPropertyName("homeRealmDiscoveryPolicies@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string HomeRealmDiscoveryPoliciesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets member of.
        /// Roles that this service principal is a member of. HTTP Methods: GET Read-only. Nullable. Supports $expand.
        /// </summary>
        [JsonPropertyName("memberOf")]
        public IServicePrincipalMemberOfCollectionWithReferencesPage MemberOf { get; set; }

        /// <summary>
        /// Gets or sets memberOfNextLink.
        /// </summary>
        [JsonPropertyName("memberOf@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string MemberOfNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets oauth2permission grants.
        /// Delegated permission grants authorizing this service principal to access an API on behalf of a signed-in user. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("oauth2PermissionGrants")]
        public IServicePrincipalOauth2PermissionGrantsCollectionWithReferencesPage Oauth2PermissionGrants { get; set; }

        /// <summary>
        /// Gets or sets oauth2PermissionGrantsNextLink.
        /// </summary>
        [JsonPropertyName("oauth2PermissionGrants@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string Oauth2PermissionGrantsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets owned objects.
        /// Directory objects that are owned by this service principal. Read-only. Nullable. Supports $expand.
        /// </summary>
        [JsonPropertyName("ownedObjects")]
        public IServicePrincipalOwnedObjectsCollectionWithReferencesPage OwnedObjects { get; set; }

        /// <summary>
        /// Gets or sets ownedObjectsNextLink.
        /// </summary>
        [JsonPropertyName("ownedObjects@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string OwnedObjectsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets owners.
        /// Directory objects that are owners of this servicePrincipal. The owners are a set of non-admin users or servicePrincipals who are allowed to modify this object. Read-only. Nullable. Supports $expand.
        /// </summary>
        [JsonPropertyName("owners")]
        public IServicePrincipalOwnersCollectionWithReferencesPage Owners { get; set; }

        /// <summary>
        /// Gets or sets ownersNextLink.
        /// </summary>
        [JsonPropertyName("owners@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string OwnersNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets token issuance policies.
        /// The tokenIssuancePolicies assigned to this service principal.
        /// </summary>
        [JsonPropertyName("tokenIssuancePolicies")]
        public IServicePrincipalTokenIssuancePoliciesCollectionWithReferencesPage TokenIssuancePolicies { get; set; }

        /// <summary>
        /// Gets or sets tokenIssuancePoliciesNextLink.
        /// </summary>
        [JsonPropertyName("tokenIssuancePolicies@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string TokenIssuancePoliciesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets token lifetime policies.
        /// The tokenLifetimePolicies assigned to this service principal.
        /// </summary>
        [JsonPropertyName("tokenLifetimePolicies")]
        public IServicePrincipalTokenLifetimePoliciesCollectionWithReferencesPage TokenLifetimePolicies { get; set; }

        /// <summary>
        /// Gets or sets tokenLifetimePoliciesNextLink.
        /// </summary>
        [JsonPropertyName("tokenLifetimePolicies@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string TokenLifetimePoliciesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets transitive member of.
        /// </summary>
        [JsonPropertyName("transitiveMemberOf")]
        public IServicePrincipalTransitiveMemberOfCollectionWithReferencesPage TransitiveMemberOf { get; set; }

        /// <summary>
        /// Gets or sets transitiveMemberOfNextLink.
        /// </summary>
        [JsonPropertyName("transitiveMemberOf@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string TransitiveMemberOfNextLink { get; set; }
    
    }
}

