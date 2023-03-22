using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class User : DirectoryObject, IParsable {
        /// <summary>A freeform text entry field for the user to describe themselves. Returned only on $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AboutMe {
            get { return BackingStore?.Get<string?>("aboutMe"); }
            set { BackingStore?.Set("aboutMe", value); }
        }
#nullable restore
#else
        public string AboutMe {
            get { return BackingStore?.Get<string>("aboutMe"); }
            set { BackingStore?.Set("aboutMe", value); }
        }
#endif
        /// <summary>true if the account is enabled; otherwise, false. This property is required when a user is created. Returned only on $select. Supports $filter (eq, ne, not, and in).</summary>
        public bool? AccountEnabled {
            get { return BackingStore?.Get<bool?>("accountEnabled"); }
            set { BackingStore?.Set("accountEnabled", value); }
        }
        /// <summary>The user&apos;s activities across devices. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserActivity>? Activities {
            get { return BackingStore?.Get<List<UserActivity>?>("activities"); }
            set { BackingStore?.Set("activities", value); }
        }
#nullable restore
#else
        public List<UserActivity> Activities {
            get { return BackingStore?.Get<List<UserActivity>>("activities"); }
            set { BackingStore?.Set("activities", value); }
        }
#endif
        /// <summary>Sets the age group of the user. Allowed values: null, Minor, NotAdult and Adult. Refer to the legal age group property definitions for further information. Returned only on $select. Supports $filter (eq, ne, not, and in).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AgeGroup {
            get { return BackingStore?.Get<string?>("ageGroup"); }
            set { BackingStore?.Set("ageGroup", value); }
        }
#nullable restore
#else
        public string AgeGroup {
            get { return BackingStore?.Get<string>("ageGroup"); }
            set { BackingStore?.Set("ageGroup", value); }
        }
#endif
        /// <summary>The user&apos;s terms of use acceptance statuses. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AgreementAcceptance>? AgreementAcceptances {
            get { return BackingStore?.Get<List<AgreementAcceptance>?>("agreementAcceptances"); }
            set { BackingStore?.Set("agreementAcceptances", value); }
        }
#nullable restore
#else
        public List<AgreementAcceptance> AgreementAcceptances {
            get { return BackingStore?.Get<List<AgreementAcceptance>>("agreementAcceptances"); }
            set { BackingStore?.Set("agreementAcceptances", value); }
        }
#endif
        /// <summary>Represents the app roles a user has been granted for an application. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AppRoleAssignment>? AppRoleAssignments {
            get { return BackingStore?.Get<List<AppRoleAssignment>?>("appRoleAssignments"); }
            set { BackingStore?.Set("appRoleAssignments", value); }
        }
#nullable restore
#else
        public List<AppRoleAssignment> AppRoleAssignments {
            get { return BackingStore?.Get<List<AppRoleAssignment>>("appRoleAssignments"); }
            set { BackingStore?.Set("appRoleAssignments", value); }
        }
#endif
        /// <summary>The licenses that are assigned to the user, including inherited (group-based) licenses. This property doesn&apos;t differentiate directly-assigned and inherited licenses. Use the licenseAssignmentStates property to identify the directly-assigned and inherited licenses.  Not nullable. Returned only on $select. Supports $filter (eq, not, /$count eq 0, /$count ne 0).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AssignedLicense>? AssignedLicenses {
            get { return BackingStore?.Get<List<AssignedLicense>?>("assignedLicenses"); }
            set { BackingStore?.Set("assignedLicenses", value); }
        }
#nullable restore
#else
        public List<AssignedLicense> AssignedLicenses {
            get { return BackingStore?.Get<List<AssignedLicense>>("assignedLicenses"); }
            set { BackingStore?.Set("assignedLicenses", value); }
        }
#endif
        /// <summary>The plans that are assigned to the user. Read-only. Not nullable. Returned only on $select. Supports $filter (eq and not).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AssignedPlan>? AssignedPlans {
            get { return BackingStore?.Get<List<AssignedPlan>?>("assignedPlans"); }
            set { BackingStore?.Set("assignedPlans", value); }
        }
#nullable restore
#else
        public List<AssignedPlan> AssignedPlans {
            get { return BackingStore?.Get<List<AssignedPlan>>("assignedPlans"); }
            set { BackingStore?.Set("assignedPlans", value); }
        }
#endif
        /// <summary>The authentication methods that are supported for the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Authentication? Authentication {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Authentication?>("authentication"); }
            set { BackingStore?.Set("authentication", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Authentication Authentication {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Authentication>("authentication"); }
            set { BackingStore?.Set("authentication", value); }
        }
#endif
        /// <summary>The authorizationInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.AuthorizationInfo? AuthorizationInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AuthorizationInfo?>("authorizationInfo"); }
            set { BackingStore?.Set("authorizationInfo", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.AuthorizationInfo AuthorizationInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AuthorizationInfo>("authorizationInfo"); }
            set { BackingStore?.Set("authorizationInfo", value); }
        }
#endif
        /// <summary>The birthday of the user. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Returned only on $select.</summary>
        public DateTimeOffset? Birthday {
            get { return BackingStore?.Get<DateTimeOffset?>("birthday"); }
            set { BackingStore?.Set("birthday", value); }
        }
        /// <summary>The telephone numbers for the user. NOTE: Although this is a string collection, only one number can be set for this property. Read-only for users synced from on-premises directory. Returned by default. Supports $filter (eq, not, ge, le, startsWith).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? BusinessPhones {
            get { return BackingStore?.Get<List<string>?>("businessPhones"); }
            set { BackingStore?.Set("businessPhones", value); }
        }
#nullable restore
#else
        public List<string> BusinessPhones {
            get { return BackingStore?.Get<List<string>>("businessPhones"); }
            set { BackingStore?.Set("businessPhones", value); }
        }
#endif
        /// <summary>The user&apos;s primary calendar. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Calendar? Calendar {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Calendar?>("calendar"); }
            set { BackingStore?.Set("calendar", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Calendar Calendar {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Calendar>("calendar"); }
            set { BackingStore?.Set("calendar", value); }
        }
#endif
        /// <summary>The user&apos;s calendar groups. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CalendarGroup>? CalendarGroups {
            get { return BackingStore?.Get<List<CalendarGroup>?>("calendarGroups"); }
            set { BackingStore?.Set("calendarGroups", value); }
        }
#nullable restore
#else
        public List<CalendarGroup> CalendarGroups {
            get { return BackingStore?.Get<List<CalendarGroup>>("calendarGroups"); }
            set { BackingStore?.Set("calendarGroups", value); }
        }
#endif
        /// <summary>The user&apos;s calendars. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.Calendar>? Calendars {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.Calendar>?>("calendars"); }
            set { BackingStore?.Set("calendars", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.Calendar> Calendars {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.Calendar>>("calendars"); }
            set { BackingStore?.Set("calendars", value); }
        }
#endif
        /// <summary>The calendar view for the calendar. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Event>? CalendarView {
            get { return BackingStore?.Get<List<Event>?>("calendarView"); }
            set { BackingStore?.Set("calendarView", value); }
        }
#nullable restore
#else
        public List<Event> CalendarView {
            get { return BackingStore?.Get<List<Event>>("calendarView"); }
            set { BackingStore?.Set("calendarView", value); }
        }
#endif
        /// <summary>The chats property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Chat>? Chats {
            get { return BackingStore?.Get<List<Chat>?>("chats"); }
            set { BackingStore?.Set("chats", value); }
        }
#nullable restore
#else
        public List<Chat> Chats {
            get { return BackingStore?.Get<List<Chat>>("chats"); }
            set { BackingStore?.Set("chats", value); }
        }
#endif
        /// <summary>The city in which the user is located. Maximum length is 128 characters. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? City {
            get { return BackingStore?.Get<string?>("city"); }
            set { BackingStore?.Set("city", value); }
        }
#nullable restore
#else
        public string City {
            get { return BackingStore?.Get<string>("city"); }
            set { BackingStore?.Set("city", value); }
        }
#endif
        /// <summary>The company name which the user is associated. This property can be useful for describing the company that an external user comes from. The maximum length is 64 characters.Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompanyName {
            get { return BackingStore?.Get<string?>("companyName"); }
            set { BackingStore?.Set("companyName", value); }
        }
#nullable restore
#else
        public string CompanyName {
            get { return BackingStore?.Get<string>("companyName"); }
            set { BackingStore?.Set("companyName", value); }
        }
#endif
        /// <summary>Sets whether consent has been obtained for minors. Allowed values: null, Granted, Denied and NotRequired. Refer to the legal age group property definitions for further information. Returned only on $select. Supports $filter (eq, ne, not, and in).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConsentProvidedForMinor {
            get { return BackingStore?.Get<string?>("consentProvidedForMinor"); }
            set { BackingStore?.Set("consentProvidedForMinor", value); }
        }
#nullable restore
#else
        public string ConsentProvidedForMinor {
            get { return BackingStore?.Get<string>("consentProvidedForMinor"); }
            set { BackingStore?.Set("consentProvidedForMinor", value); }
        }
#endif
        /// <summary>The user&apos;s contacts folders. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ContactFolder>? ContactFolders {
            get { return BackingStore?.Get<List<ContactFolder>?>("contactFolders"); }
            set { BackingStore?.Set("contactFolders", value); }
        }
#nullable restore
#else
        public List<ContactFolder> ContactFolders {
            get { return BackingStore?.Get<List<ContactFolder>>("contactFolders"); }
            set { BackingStore?.Set("contactFolders", value); }
        }
#endif
        /// <summary>The user&apos;s contacts. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Contact>? Contacts {
            get { return BackingStore?.Get<List<Contact>?>("contacts"); }
            set { BackingStore?.Set("contacts", value); }
        }
#nullable restore
#else
        public List<Contact> Contacts {
            get { return BackingStore?.Get<List<Contact>>("contacts"); }
            set { BackingStore?.Set("contacts", value); }
        }
#endif
        /// <summary>The country/region in which the user is located; for example, US or UK. Maximum length is 128 characters. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Country {
            get { return BackingStore?.Get<string?>("country"); }
            set { BackingStore?.Set("country", value); }
        }
#nullable restore
#else
        public string Country {
            get { return BackingStore?.Get<string>("country"); }
            set { BackingStore?.Set("country", value); }
        }
#endif
        /// <summary>The date and time the user was created, in ISO 8601 format and in UTC time. The value cannot be modified and is automatically populated when the entity is created. Nullable. For on-premises users, the value represents when they were first created in Azure AD. Property is null for some users created before June 2018 and on-premises users that were synced to Azure AD before June 2018. Read-only. Returned only on $select. Supports $filter (eq, ne, not , ge, le, in).</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Directory objects that were created by the user. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? CreatedObjects {
            get { return BackingStore?.Get<List<DirectoryObject>?>("createdObjects"); }
            set { BackingStore?.Set("createdObjects", value); }
        }
#nullable restore
#else
        public List<DirectoryObject> CreatedObjects {
            get { return BackingStore?.Get<List<DirectoryObject>>("createdObjects"); }
            set { BackingStore?.Set("createdObjects", value); }
        }
#endif
        /// <summary>Indicates whether the user account was created through one of the following methods:  As a regular school or work account (null). As an external account (Invitation). As a local account for an Azure Active Directory B2C tenant (LocalAccount). Through self-service sign-up by an internal user using email verification (EmailVerified). Through self-service sign-up by an external user signing up through a link that is part of a user flow (SelfServiceSignUp). Read-only.Returned only on $select. Supports $filter (eq, ne, not, in).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreationType {
            get { return BackingStore?.Get<string?>("creationType"); }
            set { BackingStore?.Set("creationType", value); }
        }
#nullable restore
#else
        public string CreationType {
            get { return BackingStore?.Get<string>("creationType"); }
            set { BackingStore?.Set("creationType", value); }
        }
#endif
        /// <summary>The name for the department in which the user works. Maximum length is 64 characters. Returned only on $select. Supports $filter (eq, ne, not , ge, le, in, and eq on null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Department {
            get { return BackingStore?.Get<string?>("department"); }
            set { BackingStore?.Set("department", value); }
        }
#nullable restore
#else
        public string Department {
            get { return BackingStore?.Get<string>("department"); }
            set { BackingStore?.Set("department", value); }
        }
#endif
        /// <summary>The limit on the maximum number of devices that the user is permitted to enroll. Allowed values are 5 or 1000.</summary>
        public int? DeviceEnrollmentLimit {
            get { return BackingStore?.Get<int?>("deviceEnrollmentLimit"); }
            set { BackingStore?.Set("deviceEnrollmentLimit", value); }
        }
        /// <summary>The list of troubleshooting events for this user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementTroubleshootingEvent>? DeviceManagementTroubleshootingEvents {
            get { return BackingStore?.Get<List<DeviceManagementTroubleshootingEvent>?>("deviceManagementTroubleshootingEvents"); }
            set { BackingStore?.Set("deviceManagementTroubleshootingEvents", value); }
        }
#nullable restore
#else
        public List<DeviceManagementTroubleshootingEvent> DeviceManagementTroubleshootingEvents {
            get { return BackingStore?.Get<List<DeviceManagementTroubleshootingEvent>>("deviceManagementTroubleshootingEvents"); }
            set { BackingStore?.Set("deviceManagementTroubleshootingEvents", value); }
        }
#endif
        /// <summary>The users and contacts that report to the user. (The users and contacts that have their manager property set to this user.) Read-only. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? DirectReports {
            get { return BackingStore?.Get<List<DirectoryObject>?>("directReports"); }
            set { BackingStore?.Set("directReports", value); }
        }
#nullable restore
#else
        public List<DirectoryObject> DirectReports {
            get { return BackingStore?.Get<List<DirectoryObject>>("directReports"); }
            set { BackingStore?.Set("directReports", value); }
        }
#endif
        /// <summary>The name displayed in the address book for the user. This is usually the combination of the user&apos;s first name, middle initial and last name. This property is required when a user is created and it cannot be cleared during updates. Maximum length is 256 characters. Returned by default. Supports $filter (eq, ne, not , ge, le, in, startsWith, and eq on null values), $orderBy, and $search.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The user&apos;s OneDrive. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Drive? Drive {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Drive?>("drive"); }
            set { BackingStore?.Set("drive", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Drive Drive {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Drive>("drive"); }
            set { BackingStore?.Set("drive", value); }
        }
#endif
        /// <summary>A collection of drives available for this user. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.Drive>? Drives {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.Drive>?>("drives"); }
            set { BackingStore?.Set("drives", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.Drive> Drives {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.Drive>>("drives"); }
            set { BackingStore?.Set("drives", value); }
        }
#endif
        /// <summary>The date and time when the user was hired or will start work in case of a future hire. Returned only on $select. Supports $filter (eq, ne, not , ge, le, in).</summary>
        public DateTimeOffset? EmployeeHireDate {
            get { return BackingStore?.Get<DateTimeOffset?>("employeeHireDate"); }
            set { BackingStore?.Set("employeeHireDate", value); }
        }
        /// <summary>The employee identifier assigned to the user by the organization. The maximum length is 16 characters. Returned only on $select. Supports $filter (eq, ne, not , ge, le, in, startsWith, and eq on null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmployeeId {
            get { return BackingStore?.Get<string?>("employeeId"); }
            set { BackingStore?.Set("employeeId", value); }
        }
#nullable restore
#else
        public string EmployeeId {
            get { return BackingStore?.Get<string>("employeeId"); }
            set { BackingStore?.Set("employeeId", value); }
        }
#endif
        /// <summary>The date and time when the user left or will leave the organization. To read this property, the calling app must be assigned the User-LifeCycleInfo.Read.All permission. To write this property, the calling app must be assigned the User.Read.All and User-LifeCycleInfo.ReadWrite.All permissions. To read this property in delegated scenarios, the admin needs one of the following Azure AD roles: Lifecycle Workflows Administrator, Global Reader, or Global Administrator. To write this property in delegated scenarios, the admin needs the Global Administrator role. Supports $filter (eq, ne, not , ge, le, in). For more information, see Configure the employeeLeaveDateTime property for a user.</summary>
        public DateTimeOffset? EmployeeLeaveDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("employeeLeaveDateTime"); }
            set { BackingStore?.Set("employeeLeaveDateTime", value); }
        }
        /// <summary>Represents organization data (e.g. division and costCenter) associated with a user. Returned only on $select. Supports $filter (eq, ne, not , ge, le, in).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.EmployeeOrgData? EmployeeOrgData {
            get { return BackingStore?.Get<Microsoft.Graph.Models.EmployeeOrgData?>("employeeOrgData"); }
            set { BackingStore?.Set("employeeOrgData", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.EmployeeOrgData EmployeeOrgData {
            get { return BackingStore?.Get<Microsoft.Graph.Models.EmployeeOrgData>("employeeOrgData"); }
            set { BackingStore?.Set("employeeOrgData", value); }
        }
#endif
        /// <summary>Captures enterprise worker type. For example, Employee, Contractor, Consultant, or Vendor. Returned only on $select. Supports $filter (eq, ne, not , ge, le, in, startsWith).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmployeeType {
            get { return BackingStore?.Get<string?>("employeeType"); }
            set { BackingStore?.Set("employeeType", value); }
        }
#nullable restore
#else
        public string EmployeeType {
            get { return BackingStore?.Get<string>("employeeType"); }
            set { BackingStore?.Set("employeeType", value); }
        }
#endif
        /// <summary>The user&apos;s events. Default is to show Events under the Default Calendar. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Event>? Events {
            get { return BackingStore?.Get<List<Event>?>("events"); }
            set { BackingStore?.Set("events", value); }
        }
#nullable restore
#else
        public List<Event> Events {
            get { return BackingStore?.Get<List<Event>>("events"); }
            set { BackingStore?.Set("events", value); }
        }
#endif
        /// <summary>The collection of open extensions defined for the user. Read-only. Supports $expand. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Extension>? Extensions {
            get { return BackingStore?.Get<List<Extension>?>("extensions"); }
            set { BackingStore?.Set("extensions", value); }
        }
#nullable restore
#else
        public List<Extension> Extensions {
            get { return BackingStore?.Get<List<Extension>>("extensions"); }
            set { BackingStore?.Set("extensions", value); }
        }
#endif
        /// <summary>For an external user invited to the tenant using the invitation API, this property represents the invited user&apos;s invitation status. For invited users, the state can be PendingAcceptance or Accepted, or null for all other users. Returned only on $select. Supports $filter (eq, ne, not , in).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalUserState {
            get { return BackingStore?.Get<string?>("externalUserState"); }
            set { BackingStore?.Set("externalUserState", value); }
        }
#nullable restore
#else
        public string ExternalUserState {
            get { return BackingStore?.Get<string>("externalUserState"); }
            set { BackingStore?.Set("externalUserState", value); }
        }
#endif
        /// <summary>Shows the timestamp for the latest change to the externalUserState property. Returned only on $select. Supports $filter (eq, ne, not , in).</summary>
        public DateTimeOffset? ExternalUserStateChangeDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("externalUserStateChangeDateTime"); }
            set { BackingStore?.Set("externalUserStateChangeDateTime", value); }
        }
        /// <summary>The fax number of the user. Returned only on $select. Supports $filter (eq, ne, not , ge, le, in, startsWith, and eq on null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FaxNumber {
            get { return BackingStore?.Get<string?>("faxNumber"); }
            set { BackingStore?.Set("faxNumber", value); }
        }
#nullable restore
#else
        public string FaxNumber {
            get { return BackingStore?.Get<string>("faxNumber"); }
            set { BackingStore?.Set("faxNumber", value); }
        }
#endif
        /// <summary>The followedSites property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Site>? FollowedSites {
            get { return BackingStore?.Get<List<Site>?>("followedSites"); }
            set { BackingStore?.Set("followedSites", value); }
        }
#nullable restore
#else
        public List<Site> FollowedSites {
            get { return BackingStore?.Get<List<Site>>("followedSites"); }
            set { BackingStore?.Set("followedSites", value); }
        }
#endif
        /// <summary>The given name (first name) of the user. Maximum length is 64 characters. Returned by default. Supports $filter (eq, ne, not , ge, le, in, startsWith, and eq on null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GivenName {
            get { return BackingStore?.Get<string?>("givenName"); }
            set { BackingStore?.Set("givenName", value); }
        }
#nullable restore
#else
        public string GivenName {
            get { return BackingStore?.Get<string>("givenName"); }
            set { BackingStore?.Set("givenName", value); }
        }
#endif
        /// <summary>The hire date of the user. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Returned only on $select.  Note: This property is specific to SharePoint Online. We recommend using the native employeeHireDate property to set and update hire date values using Microsoft Graph APIs.</summary>
        public DateTimeOffset? HireDate {
            get { return BackingStore?.Get<DateTimeOffset?>("hireDate"); }
            set { BackingStore?.Set("hireDate", value); }
        }
        /// <summary>Represents the identities that can be used to sign in to this user account. An identity can be provided by Microsoft (also known as a local account), by organizations, or by social identity providers such as Facebook, Google, and Microsoft, and tied to a user account. May contain multiple items with the same signInType value. Returned only on $select. Supports $filter (eq) including on null values, only where the signInType is not userPrincipalName.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ObjectIdentity>? Identities {
            get { return BackingStore?.Get<List<ObjectIdentity>?>("identities"); }
            set { BackingStore?.Set("identities", value); }
        }
#nullable restore
#else
        public List<ObjectIdentity> Identities {
            get { return BackingStore?.Get<List<ObjectIdentity>>("identities"); }
            set { BackingStore?.Set("identities", value); }
        }
#endif
        /// <summary>The instant message voice over IP (VOIP) session initiation protocol (SIP) addresses for the user. Read-only. Returned only on $select. Supports $filter (eq, not, ge, le, startsWith).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ImAddresses {
            get { return BackingStore?.Get<List<string>?>("imAddresses"); }
            set { BackingStore?.Set("imAddresses", value); }
        }
#nullable restore
#else
        public List<string> ImAddresses {
            get { return BackingStore?.Get<List<string>>("imAddresses"); }
            set { BackingStore?.Set("imAddresses", value); }
        }
#endif
        /// <summary>Relevance classification of the user&apos;s messages based on explicit designations which override inferred relevance or importance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.InferenceClassification? InferenceClassification {
            get { return BackingStore?.Get<Microsoft.Graph.Models.InferenceClassification?>("inferenceClassification"); }
            set { BackingStore?.Set("inferenceClassification", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.InferenceClassification InferenceClassification {
            get { return BackingStore?.Get<Microsoft.Graph.Models.InferenceClassification>("inferenceClassification"); }
            set { BackingStore?.Set("inferenceClassification", value); }
        }
#endif
        /// <summary>The insights property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OfficeGraphInsights? Insights {
            get { return BackingStore?.Get<OfficeGraphInsights?>("insights"); }
            set { BackingStore?.Set("insights", value); }
        }
#nullable restore
#else
        public OfficeGraphInsights Insights {
            get { return BackingStore?.Get<OfficeGraphInsights>("insights"); }
            set { BackingStore?.Set("insights", value); }
        }
#endif
        /// <summary>A list for the user to describe their interests. Returned only on $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Interests {
            get { return BackingStore?.Get<List<string>?>("interests"); }
            set { BackingStore?.Set("interests", value); }
        }
#nullable restore
#else
        public List<string> Interests {
            get { return BackingStore?.Get<List<string>>("interests"); }
            set { BackingStore?.Set("interests", value); }
        }
#endif
        /// <summary>Do not use – reserved for future use.</summary>
        public bool? IsResourceAccount {
            get { return BackingStore?.Get<bool?>("isResourceAccount"); }
            set { BackingStore?.Set("isResourceAccount", value); }
        }
        /// <summary>The user&apos;s job title. Maximum length is 128 characters. Returned by default. Supports $filter (eq, ne, not , ge, le, in, startsWith, and eq on null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JobTitle {
            get { return BackingStore?.Get<string?>("jobTitle"); }
            set { BackingStore?.Set("jobTitle", value); }
        }
#nullable restore
#else
        public string JobTitle {
            get { return BackingStore?.Get<string>("jobTitle"); }
            set { BackingStore?.Set("jobTitle", value); }
        }
#endif
        /// <summary>The joinedTeams property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Team>? JoinedTeams {
            get { return BackingStore?.Get<List<Team>?>("joinedTeams"); }
            set { BackingStore?.Set("joinedTeams", value); }
        }
#nullable restore
#else
        public List<Team> JoinedTeams {
            get { return BackingStore?.Get<List<Team>>("joinedTeams"); }
            set { BackingStore?.Set("joinedTeams", value); }
        }
#endif
        /// <summary>The time when this Azure AD user last changed their password or when their password was created, whichever date the latest action was performed. The date and time information uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Returned only on $select.</summary>
        public DateTimeOffset? LastPasswordChangeDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastPasswordChangeDateTime"); }
            set { BackingStore?.Set("lastPasswordChangeDateTime", value); }
        }
        /// <summary>Used by enterprise applications to determine the legal age group of the user. This property is read-only and calculated based on ageGroup and consentProvidedForMinor properties. Allowed values: null, MinorWithOutParentalConsent, MinorWithParentalConsent, MinorNoParentalConsentRequired, NotAdult and Adult. Refer to the legal age group property definitions for further information. Returned only on $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LegalAgeGroupClassification {
            get { return BackingStore?.Get<string?>("legalAgeGroupClassification"); }
            set { BackingStore?.Set("legalAgeGroupClassification", value); }
        }
#nullable restore
#else
        public string LegalAgeGroupClassification {
            get { return BackingStore?.Get<string>("legalAgeGroupClassification"); }
            set { BackingStore?.Set("legalAgeGroupClassification", value); }
        }
#endif
        /// <summary>State of license assignments for this user. Also indicates licenses that are directly-assigned and those that the user has inherited through group memberships. Read-only. Returned only on $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<LicenseAssignmentState>? LicenseAssignmentStates {
            get { return BackingStore?.Get<List<LicenseAssignmentState>?>("licenseAssignmentStates"); }
            set { BackingStore?.Set("licenseAssignmentStates", value); }
        }
#nullable restore
#else
        public List<LicenseAssignmentState> LicenseAssignmentStates {
            get { return BackingStore?.Get<List<LicenseAssignmentState>>("licenseAssignmentStates"); }
            set { BackingStore?.Set("licenseAssignmentStates", value); }
        }
#endif
        /// <summary>A collection of this user&apos;s license details. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.LicenseDetails>? LicenseDetails {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.LicenseDetails>?>("licenseDetails"); }
            set { BackingStore?.Set("licenseDetails", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.LicenseDetails> LicenseDetails {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.LicenseDetails>>("licenseDetails"); }
            set { BackingStore?.Set("licenseDetails", value); }
        }
#endif
        /// <summary>The SMTP address for the user, for example, jeff@contoso.onmicrosoft.com. Changes to this property will also update the user&apos;s proxyAddresses collection to include the value as an SMTP address. This property cannot contain accent characters.  NOTE: We do not recommend updating this property for Azure AD B2C user profiles. Use the otherMails property instead. Returned by default. Supports $filter (eq, ne, not, ge, le, in, startsWith, endsWith, and eq on null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Mail {
            get { return BackingStore?.Get<string?>("mail"); }
            set { BackingStore?.Set("mail", value); }
        }
#nullable restore
#else
        public string Mail {
            get { return BackingStore?.Get<string>("mail"); }
            set { BackingStore?.Set("mail", value); }
        }
#endif
        /// <summary>Settings for the primary mailbox of the signed-in user. You can get or update settings for sending automatic replies to incoming messages, locale and time zone. Returned only on $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.MailboxSettings? MailboxSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Models.MailboxSettings?>("mailboxSettings"); }
            set { BackingStore?.Set("mailboxSettings", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.MailboxSettings MailboxSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Models.MailboxSettings>("mailboxSettings"); }
            set { BackingStore?.Set("mailboxSettings", value); }
        }
#endif
        /// <summary>The user&apos;s mail folders. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MailFolder>? MailFolders {
            get { return BackingStore?.Get<List<MailFolder>?>("mailFolders"); }
            set { BackingStore?.Set("mailFolders", value); }
        }
#nullable restore
#else
        public List<MailFolder> MailFolders {
            get { return BackingStore?.Get<List<MailFolder>>("mailFolders"); }
            set { BackingStore?.Set("mailFolders", value); }
        }
#endif
        /// <summary>The mail alias for the user. This property must be specified when a user is created. Maximum length is 64 characters. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MailNickname {
            get { return BackingStore?.Get<string?>("mailNickname"); }
            set { BackingStore?.Set("mailNickname", value); }
        }
#nullable restore
#else
        public string MailNickname {
            get { return BackingStore?.Get<string>("mailNickname"); }
            set { BackingStore?.Set("mailNickname", value); }
        }
#endif
        /// <summary>Zero or more managed app registrations that belong to the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedAppRegistration>? ManagedAppRegistrations {
            get { return BackingStore?.Get<List<ManagedAppRegistration>?>("managedAppRegistrations"); }
            set { BackingStore?.Set("managedAppRegistrations", value); }
        }
#nullable restore
#else
        public List<ManagedAppRegistration> ManagedAppRegistrations {
            get { return BackingStore?.Get<List<ManagedAppRegistration>>("managedAppRegistrations"); }
            set { BackingStore?.Set("managedAppRegistrations", value); }
        }
#endif
        /// <summary>The managed devices associated with the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedDevice>? ManagedDevices {
            get { return BackingStore?.Get<List<ManagedDevice>?>("managedDevices"); }
            set { BackingStore?.Set("managedDevices", value); }
        }
#nullable restore
#else
        public List<ManagedDevice> ManagedDevices {
            get { return BackingStore?.Get<List<ManagedDevice>>("managedDevices"); }
            set { BackingStore?.Set("managedDevices", value); }
        }
#endif
        /// <summary>The user or contact that is this user&apos;s manager. Read-only. (HTTP Methods: GET, PUT, DELETE.). Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DirectoryObject? Manager {
            get { return BackingStore?.Get<DirectoryObject?>("manager"); }
            set { BackingStore?.Set("manager", value); }
        }
#nullable restore
#else
        public DirectoryObject Manager {
            get { return BackingStore?.Get<DirectoryObject>("manager"); }
            set { BackingStore?.Set("manager", value); }
        }
#endif
        /// <summary>The groups and directory roles that the user is a member of. Read-only. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? MemberOf {
            get { return BackingStore?.Get<List<DirectoryObject>?>("memberOf"); }
            set { BackingStore?.Set("memberOf", value); }
        }
#nullable restore
#else
        public List<DirectoryObject> MemberOf {
            get { return BackingStore?.Get<List<DirectoryObject>>("memberOf"); }
            set { BackingStore?.Set("memberOf", value); }
        }
#endif
        /// <summary>The messages in a mailbox or folder. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Message>? Messages {
            get { return BackingStore?.Get<List<Message>?>("messages"); }
            set { BackingStore?.Set("messages", value); }
        }
#nullable restore
#else
        public List<Message> Messages {
            get { return BackingStore?.Get<List<Message>>("messages"); }
            set { BackingStore?.Set("messages", value); }
        }
#endif
        /// <summary>The primary cellular telephone number for the user. Read-only for users synced from on-premises directory. Maximum length is 64 characters. Returned by default. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MobilePhone {
            get { return BackingStore?.Get<string?>("mobilePhone"); }
            set { BackingStore?.Set("mobilePhone", value); }
        }
#nullable restore
#else
        public string MobilePhone {
            get { return BackingStore?.Get<string>("mobilePhone"); }
            set { BackingStore?.Set("mobilePhone", value); }
        }
#endif
        /// <summary>The URL for the user&apos;s personal site. Returned only on $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MySite {
            get { return BackingStore?.Get<string?>("mySite"); }
            set { BackingStore?.Set("mySite", value); }
        }
#nullable restore
#else
        public string MySite {
            get { return BackingStore?.Get<string>("mySite"); }
            set { BackingStore?.Set("mySite", value); }
        }
#endif
        /// <summary>The oauth2PermissionGrants property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OAuth2PermissionGrant>? Oauth2PermissionGrants {
            get { return BackingStore?.Get<List<OAuth2PermissionGrant>?>("oauth2PermissionGrants"); }
            set { BackingStore?.Set("oauth2PermissionGrants", value); }
        }
#nullable restore
#else
        public List<OAuth2PermissionGrant> Oauth2PermissionGrants {
            get { return BackingStore?.Get<List<OAuth2PermissionGrant>>("oauth2PermissionGrants"); }
            set { BackingStore?.Set("oauth2PermissionGrants", value); }
        }
#endif
        /// <summary>The office location in the user&apos;s place of business. Returned by default. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OfficeLocation {
            get { return BackingStore?.Get<string?>("officeLocation"); }
            set { BackingStore?.Set("officeLocation", value); }
        }
#nullable restore
#else
        public string OfficeLocation {
            get { return BackingStore?.Get<string>("officeLocation"); }
            set { BackingStore?.Set("officeLocation", value); }
        }
#endif
        /// <summary>The onenote property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Onenote? Onenote {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Onenote?>("onenote"); }
            set { BackingStore?.Set("onenote", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Onenote Onenote {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Onenote>("onenote"); }
            set { BackingStore?.Set("onenote", value); }
        }
#endif
        /// <summary>The onlineMeetings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OnlineMeeting>? OnlineMeetings {
            get { return BackingStore?.Get<List<OnlineMeeting>?>("onlineMeetings"); }
            set { BackingStore?.Set("onlineMeetings", value); }
        }
#nullable restore
#else
        public List<OnlineMeeting> OnlineMeetings {
            get { return BackingStore?.Get<List<OnlineMeeting>>("onlineMeetings"); }
            set { BackingStore?.Set("onlineMeetings", value); }
        }
#endif
        /// <summary>Contains the on-premises Active Directory distinguished name or DN. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect. Read-only. Returned only on $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OnPremisesDistinguishedName {
            get { return BackingStore?.Get<string?>("onPremisesDistinguishedName"); }
            set { BackingStore?.Set("onPremisesDistinguishedName", value); }
        }
#nullable restore
#else
        public string OnPremisesDistinguishedName {
            get { return BackingStore?.Get<string>("onPremisesDistinguishedName"); }
            set { BackingStore?.Set("onPremisesDistinguishedName", value); }
        }
#endif
        /// <summary>Contains the on-premises domainFQDN, also called dnsDomainName synchronized from the on-premises directory. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect. Read-only. Returned only on $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OnPremisesDomainName {
            get { return BackingStore?.Get<string?>("onPremisesDomainName"); }
            set { BackingStore?.Set("onPremisesDomainName", value); }
        }
#nullable restore
#else
        public string OnPremisesDomainName {
            get { return BackingStore?.Get<string>("onPremisesDomainName"); }
            set { BackingStore?.Set("onPremisesDomainName", value); }
        }
#endif
        /// <summary>Contains extensionAttributes1-15 for the user. These extension attributes are also known as Exchange custom attributes 1-15. For an onPremisesSyncEnabled user, the source of authority for this set of properties is the on-premises and is read-only. For a cloud-only user (where onPremisesSyncEnabled is false), these properties can be set during creation or update of a user object.  For a cloud-only user previously synced from on-premises Active Directory, these properties are read-only in Microsoft Graph but can be fully managed through the Exchange Admin Center or the Exchange Online V2 module in PowerShell. Returned only on $select. Supports $filter (eq, ne, not, in).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.OnPremisesExtensionAttributes? OnPremisesExtensionAttributes {
            get { return BackingStore?.Get<Microsoft.Graph.Models.OnPremisesExtensionAttributes?>("onPremisesExtensionAttributes"); }
            set { BackingStore?.Set("onPremisesExtensionAttributes", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.OnPremisesExtensionAttributes OnPremisesExtensionAttributes {
            get { return BackingStore?.Get<Microsoft.Graph.Models.OnPremisesExtensionAttributes>("onPremisesExtensionAttributes"); }
            set { BackingStore?.Set("onPremisesExtensionAttributes", value); }
        }
#endif
        /// <summary>This property is used to associate an on-premises Active Directory user account to their Azure AD user object. This property must be specified when creating a new user account in the Graph if you are using a federated domain for the user&apos;s userPrincipalName (UPN) property. NOTE: The $ and _ characters cannot be used when specifying this property. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in)..</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OnPremisesImmutableId {
            get { return BackingStore?.Get<string?>("onPremisesImmutableId"); }
            set { BackingStore?.Set("onPremisesImmutableId", value); }
        }
#nullable restore
#else
        public string OnPremisesImmutableId {
            get { return BackingStore?.Get<string>("onPremisesImmutableId"); }
            set { BackingStore?.Set("onPremisesImmutableId", value); }
        }
#endif
        /// <summary>Indicates the last time at which the object was synced with the on-premises directory; for example: 2013-02-16T03:04:54Z. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in).</summary>
        public DateTimeOffset? OnPremisesLastSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("onPremisesLastSyncDateTime"); }
            set { BackingStore?.Set("onPremisesLastSyncDateTime", value); }
        }
        /// <summary>Errors when using Microsoft synchronization product during provisioning. Returned only on $select. Supports $filter (eq, not, ge, le).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OnPremisesProvisioningError>? OnPremisesProvisioningErrors {
            get { return BackingStore?.Get<List<OnPremisesProvisioningError>?>("onPremisesProvisioningErrors"); }
            set { BackingStore?.Set("onPremisesProvisioningErrors", value); }
        }
#nullable restore
#else
        public List<OnPremisesProvisioningError> OnPremisesProvisioningErrors {
            get { return BackingStore?.Get<List<OnPremisesProvisioningError>>("onPremisesProvisioningErrors"); }
            set { BackingStore?.Set("onPremisesProvisioningErrors", value); }
        }
#endif
        /// <summary>Contains the on-premises samAccountName synchronized from the on-premises directory. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect. Read-only. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OnPremisesSamAccountName {
            get { return BackingStore?.Get<string?>("onPremisesSamAccountName"); }
            set { BackingStore?.Set("onPremisesSamAccountName", value); }
        }
#nullable restore
#else
        public string OnPremisesSamAccountName {
            get { return BackingStore?.Get<string>("onPremisesSamAccountName"); }
            set { BackingStore?.Set("onPremisesSamAccountName", value); }
        }
#endif
        /// <summary>Contains the on-premises security identifier (SID) for the user that was synchronized from on-premises to the cloud. Read-only. Returned only on $select.  Supports $filter (eq including on null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OnPremisesSecurityIdentifier {
            get { return BackingStore?.Get<string?>("onPremisesSecurityIdentifier"); }
            set { BackingStore?.Set("onPremisesSecurityIdentifier", value); }
        }
#nullable restore
#else
        public string OnPremisesSecurityIdentifier {
            get { return BackingStore?.Get<string>("onPremisesSecurityIdentifier"); }
            set { BackingStore?.Set("onPremisesSecurityIdentifier", value); }
        }
#endif
        /// <summary>true if this user object is currently being synced from an on-premises Active Directory (AD); otherwise the user isn&apos;t being synced and can be managed in Azure Active Directory (Azure AD). Read-only. Returned only on $select. Supports $filter (eq, ne, not, in, and eq on null values).</summary>
        public bool? OnPremisesSyncEnabled {
            get { return BackingStore?.Get<bool?>("onPremisesSyncEnabled"); }
            set { BackingStore?.Set("onPremisesSyncEnabled", value); }
        }
        /// <summary>Contains the on-premises userPrincipalName synchronized from the on-premises directory. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect. Read-only. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OnPremisesUserPrincipalName {
            get { return BackingStore?.Get<string?>("onPremisesUserPrincipalName"); }
            set { BackingStore?.Set("onPremisesUserPrincipalName", value); }
        }
#nullable restore
#else
        public string OnPremisesUserPrincipalName {
            get { return BackingStore?.Get<string>("onPremisesUserPrincipalName"); }
            set { BackingStore?.Set("onPremisesUserPrincipalName", value); }
        }
#endif
        /// <summary>A list of additional email addresses for the user; for example: [&apos;bob@contoso.com&apos;, &apos;Robert@fabrikam.com&apos;]. NOTE: This property cannot contain accent characters. Returned only on $select. Supports $filter (eq, not, ge, le, in, startsWith, endsWith, /$count eq 0, /$count ne 0).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? OtherMails {
            get { return BackingStore?.Get<List<string>?>("otherMails"); }
            set { BackingStore?.Set("otherMails", value); }
        }
#nullable restore
#else
        public List<string> OtherMails {
            get { return BackingStore?.Get<List<string>>("otherMails"); }
            set { BackingStore?.Set("otherMails", value); }
        }
#endif
        /// <summary>The outlook property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OutlookUser? Outlook {
            get { return BackingStore?.Get<OutlookUser?>("outlook"); }
            set { BackingStore?.Set("outlook", value); }
        }
#nullable restore
#else
        public OutlookUser Outlook {
            get { return BackingStore?.Get<OutlookUser>("outlook"); }
            set { BackingStore?.Set("outlook", value); }
        }
#endif
        /// <summary>Devices that are owned by the user. Read-only. Nullable. Supports $expand and $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? OwnedDevices {
            get { return BackingStore?.Get<List<DirectoryObject>?>("ownedDevices"); }
            set { BackingStore?.Set("ownedDevices", value); }
        }
#nullable restore
#else
        public List<DirectoryObject> OwnedDevices {
            get { return BackingStore?.Get<List<DirectoryObject>>("ownedDevices"); }
            set { BackingStore?.Set("ownedDevices", value); }
        }
#endif
        /// <summary>Directory objects that are owned by the user. Read-only. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? OwnedObjects {
            get { return BackingStore?.Get<List<DirectoryObject>?>("ownedObjects"); }
            set { BackingStore?.Set("ownedObjects", value); }
        }
#nullable restore
#else
        public List<DirectoryObject> OwnedObjects {
            get { return BackingStore?.Get<List<DirectoryObject>>("ownedObjects"); }
            set { BackingStore?.Set("ownedObjects", value); }
        }
#endif
        /// <summary>Specifies password policies for the user. This value is an enumeration with one possible value being DisableStrongPassword, which allows weaker passwords than the default policy to be specified. DisablePasswordExpiration can also be specified. The two may be specified together; for example: DisablePasswordExpiration, DisableStrongPassword. Returned only on $select. For more information on the default password policies, see Azure AD pasword policies. Supports $filter (ne, not, and eq on null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PasswordPolicies {
            get { return BackingStore?.Get<string?>("passwordPolicies"); }
            set { BackingStore?.Set("passwordPolicies", value); }
        }
#nullable restore
#else
        public string PasswordPolicies {
            get { return BackingStore?.Get<string>("passwordPolicies"); }
            set { BackingStore?.Set("passwordPolicies", value); }
        }
#endif
        /// <summary>Specifies the password profile for the user. The profile contains the user’s password. This property is required when a user is created. The password in the profile must satisfy minimum requirements as specified by the passwordPolicies property. By default, a strong password is required. Returned only on $select. Supports $filter (eq, ne, not, in, and eq on null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.PasswordProfile? PasswordProfile {
            get { return BackingStore?.Get<Microsoft.Graph.Models.PasswordProfile?>("passwordProfile"); }
            set { BackingStore?.Set("passwordProfile", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.PasswordProfile PasswordProfile {
            get { return BackingStore?.Get<Microsoft.Graph.Models.PasswordProfile>("passwordProfile"); }
            set { BackingStore?.Set("passwordProfile", value); }
        }
#endif
        /// <summary>A list for the user to enumerate their past projects. Returned only on $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? PastProjects {
            get { return BackingStore?.Get<List<string>?>("pastProjects"); }
            set { BackingStore?.Set("pastProjects", value); }
        }
#nullable restore
#else
        public List<string> PastProjects {
            get { return BackingStore?.Get<List<string>>("pastProjects"); }
            set { BackingStore?.Set("pastProjects", value); }
        }
#endif
        /// <summary>People that are relevant to the user. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Person>? People {
            get { return BackingStore?.Get<List<Person>?>("people"); }
            set { BackingStore?.Set("people", value); }
        }
#nullable restore
#else
        public List<Person> People {
            get { return BackingStore?.Get<List<Person>>("people"); }
            set { BackingStore?.Set("people", value); }
        }
#endif
        /// <summary>The user&apos;s profile photo. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ProfilePhoto? Photo {
            get { return BackingStore?.Get<ProfilePhoto?>("photo"); }
            set { BackingStore?.Set("photo", value); }
        }
#nullable restore
#else
        public ProfilePhoto Photo {
            get { return BackingStore?.Get<ProfilePhoto>("photo"); }
            set { BackingStore?.Set("photo", value); }
        }
#endif
        /// <summary>The photos property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ProfilePhoto>? Photos {
            get { return BackingStore?.Get<List<ProfilePhoto>?>("photos"); }
            set { BackingStore?.Set("photos", value); }
        }
#nullable restore
#else
        public List<ProfilePhoto> Photos {
            get { return BackingStore?.Get<List<ProfilePhoto>>("photos"); }
            set { BackingStore?.Set("photos", value); }
        }
#endif
        /// <summary>Entry-point to the Planner resource that might exist for a user. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlannerUser? Planner {
            get { return BackingStore?.Get<PlannerUser?>("planner"); }
            set { BackingStore?.Set("planner", value); }
        }
#nullable restore
#else
        public PlannerUser Planner {
            get { return BackingStore?.Get<PlannerUser>("planner"); }
            set { BackingStore?.Set("planner", value); }
        }
#endif
        /// <summary>The postal code for the user&apos;s postal address. The postal code is specific to the user&apos;s country/region. In the United States of America, this attribute contains the ZIP code. Maximum length is 40 characters. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PostalCode {
            get { return BackingStore?.Get<string?>("postalCode"); }
            set { BackingStore?.Set("postalCode", value); }
        }
#nullable restore
#else
        public string PostalCode {
            get { return BackingStore?.Get<string>("postalCode"); }
            set { BackingStore?.Set("postalCode", value); }
        }
#endif
        /// <summary>The preferred data location for the user. For more information, see OneDrive Online Multi-Geo.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PreferredDataLocation {
            get { return BackingStore?.Get<string?>("preferredDataLocation"); }
            set { BackingStore?.Set("preferredDataLocation", value); }
        }
#nullable restore
#else
        public string PreferredDataLocation {
            get { return BackingStore?.Get<string>("preferredDataLocation"); }
            set { BackingStore?.Set("preferredDataLocation", value); }
        }
#endif
        /// <summary>The preferred language for the user. Should follow ISO 639-1 Code; for example en-US. Returned by default. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PreferredLanguage {
            get { return BackingStore?.Get<string?>("preferredLanguage"); }
            set { BackingStore?.Set("preferredLanguage", value); }
        }
#nullable restore
#else
        public string PreferredLanguage {
            get { return BackingStore?.Get<string>("preferredLanguage"); }
            set { BackingStore?.Set("preferredLanguage", value); }
        }
#endif
        /// <summary>The preferred name for the user. Not Supported. This attribute returns an empty string.Returned only on $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PreferredName {
            get { return BackingStore?.Get<string?>("preferredName"); }
            set { BackingStore?.Set("preferredName", value); }
        }
#nullable restore
#else
        public string PreferredName {
            get { return BackingStore?.Get<string>("preferredName"); }
            set { BackingStore?.Set("preferredName", value); }
        }
#endif
        /// <summary>The presence property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Presence? Presence {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Presence?>("presence"); }
            set { BackingStore?.Set("presence", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Presence Presence {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Presence>("presence"); }
            set { BackingStore?.Set("presence", value); }
        }
#endif
        /// <summary>The plans that are provisioned for the user. Read-only. Not nullable. Returned only on $select. Supports $filter (eq, not, ge, le).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ProvisionedPlan>? ProvisionedPlans {
            get { return BackingStore?.Get<List<ProvisionedPlan>?>("provisionedPlans"); }
            set { BackingStore?.Set("provisionedPlans", value); }
        }
#nullable restore
#else
        public List<ProvisionedPlan> ProvisionedPlans {
            get { return BackingStore?.Get<List<ProvisionedPlan>>("provisionedPlans"); }
            set { BackingStore?.Set("provisionedPlans", value); }
        }
#endif
        /// <summary>For example: [&apos;SMTP: bob@contoso.com&apos;, &apos;smtp: bob@sales.contoso.com&apos;]. Changes to the mail property will also update this collection to include the value as an SMTP address. For more information, see mail and proxyAddresses properties. The proxy address prefixed with SMTP (capitalized) is the primary proxy address while those prefixed with smtp are the secondary proxy addresses. For Azure AD B2C accounts, this property has a limit of ten unique addresses. Read-only in Microsoft Graph; you can update this property only through the Microsoft 365 admin center. Not nullable. Returned only on $select. Supports $filter (eq, not, ge, le, startsWith, endsWith, /$count eq 0, /$count ne 0).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ProxyAddresses {
            get { return BackingStore?.Get<List<string>?>("proxyAddresses"); }
            set { BackingStore?.Set("proxyAddresses", value); }
        }
#nullable restore
#else
        public List<string> ProxyAddresses {
            get { return BackingStore?.Get<List<string>>("proxyAddresses"); }
            set { BackingStore?.Set("proxyAddresses", value); }
        }
#endif
        /// <summary>Devices that are registered for the user. Read-only. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? RegisteredDevices {
            get { return BackingStore?.Get<List<DirectoryObject>?>("registeredDevices"); }
            set { BackingStore?.Set("registeredDevices", value); }
        }
#nullable restore
#else
        public List<DirectoryObject> RegisteredDevices {
            get { return BackingStore?.Get<List<DirectoryObject>>("registeredDevices"); }
            set { BackingStore?.Set("registeredDevices", value); }
        }
#endif
        /// <summary>A list for the user to enumerate their responsibilities. Returned only on $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Responsibilities {
            get { return BackingStore?.Get<List<string>?>("responsibilities"); }
            set { BackingStore?.Set("responsibilities", value); }
        }
#nullable restore
#else
        public List<string> Responsibilities {
            get { return BackingStore?.Get<List<string>>("responsibilities"); }
            set { BackingStore?.Set("responsibilities", value); }
        }
#endif
        /// <summary>A list for the user to enumerate the schools they have attended. Returned only on $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Schools {
            get { return BackingStore?.Get<List<string>?>("schools"); }
            set { BackingStore?.Set("schools", value); }
        }
#nullable restore
#else
        public List<string> Schools {
            get { return BackingStore?.Get<List<string>>("schools"); }
            set { BackingStore?.Set("schools", value); }
        }
#endif
        /// <summary>The scopedRoleMemberOf property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ScopedRoleMembership>? ScopedRoleMemberOf {
            get { return BackingStore?.Get<List<ScopedRoleMembership>?>("scopedRoleMemberOf"); }
            set { BackingStore?.Set("scopedRoleMemberOf", value); }
        }
#nullable restore
#else
        public List<ScopedRoleMembership> ScopedRoleMemberOf {
            get { return BackingStore?.Get<List<ScopedRoleMembership>>("scopedRoleMemberOf"); }
            set { BackingStore?.Set("scopedRoleMemberOf", value); }
        }
#endif
        /// <summary>Security identifier (SID) of the user, used in Windows scenarios. Read-only. Returned by default. Supports $select and $filter (eq, not, ge, le, startsWith).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SecurityIdentifier {
            get { return BackingStore?.Get<string?>("securityIdentifier"); }
            set { BackingStore?.Set("securityIdentifier", value); }
        }
#nullable restore
#else
        public string SecurityIdentifier {
            get { return BackingStore?.Get<string>("securityIdentifier"); }
            set { BackingStore?.Set("securityIdentifier", value); }
        }
#endif
        /// <summary>The settings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserSettings? Settings {
            get { return BackingStore?.Get<UserSettings?>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#nullable restore
#else
        public UserSettings Settings {
            get { return BackingStore?.Get<UserSettings>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#endif
        /// <summary>Do not use in Microsoft Graph. Manage this property through the Microsoft 365 admin center instead. Represents whether the user should be included in the Outlook global address list. See Known issue.</summary>
        public bool? ShowInAddressList {
            get { return BackingStore?.Get<bool?>("showInAddressList"); }
            set { BackingStore?.Set("showInAddressList", value); }
        }
        /// <summary>Any refresh tokens or sessions tokens (session cookies) issued before this time are invalid, and applications will get an error when using an invalid refresh or sessions token to acquire a delegated access token (to access APIs such as Microsoft Graph).  If this happens, the application will need to acquire a new refresh token by making a request to the authorize endpoint. Read-only. Use revokeSignInSessions to reset. Returned only on $select.</summary>
        public DateTimeOffset? SignInSessionsValidFromDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("signInSessionsValidFromDateTime"); }
            set { BackingStore?.Set("signInSessionsValidFromDateTime", value); }
        }
        /// <summary>A list for the user to enumerate their skills. Returned only on $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Skills {
            get { return BackingStore?.Get<List<string>?>("skills"); }
            set { BackingStore?.Set("skills", value); }
        }
#nullable restore
#else
        public List<string> Skills {
            get { return BackingStore?.Get<List<string>>("skills"); }
            set { BackingStore?.Set("skills", value); }
        }
#endif
        /// <summary>The state or province in the user&apos;s address. Maximum length is 128 characters. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State {
            get { return BackingStore?.Get<string?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
#nullable restore
#else
        public string State {
            get { return BackingStore?.Get<string>("state"); }
            set { BackingStore?.Set("state", value); }
        }
#endif
        /// <summary>The street address of the user&apos;s place of business. Maximum length is 1024 characters. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StreetAddress {
            get { return BackingStore?.Get<string?>("streetAddress"); }
            set { BackingStore?.Set("streetAddress", value); }
        }
#nullable restore
#else
        public string StreetAddress {
            get { return BackingStore?.Get<string>("streetAddress"); }
            set { BackingStore?.Set("streetAddress", value); }
        }
#endif
        /// <summary>The user&apos;s surname (family name or last name). Maximum length is 64 characters. Returned by default. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Surname {
            get { return BackingStore?.Get<string?>("surname"); }
            set { BackingStore?.Set("surname", value); }
        }
#nullable restore
#else
        public string Surname {
            get { return BackingStore?.Get<string>("surname"); }
            set { BackingStore?.Set("surname", value); }
        }
#endif
        /// <summary>The teamwork property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserTeamwork? Teamwork {
            get { return BackingStore?.Get<UserTeamwork?>("teamwork"); }
            set { BackingStore?.Set("teamwork", value); }
        }
#nullable restore
#else
        public UserTeamwork Teamwork {
            get { return BackingStore?.Get<UserTeamwork>("teamwork"); }
            set { BackingStore?.Set("teamwork", value); }
        }
#endif
        /// <summary>Represents the To Do services available to a user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Todo? Todo {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Todo?>("todo"); }
            set { BackingStore?.Set("todo", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Todo Todo {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Todo>("todo"); }
            set { BackingStore?.Set("todo", value); }
        }
#endif
        /// <summary>The groups, including nested groups, and directory roles that a user is a member of. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? TransitiveMemberOf {
            get { return BackingStore?.Get<List<DirectoryObject>?>("transitiveMemberOf"); }
            set { BackingStore?.Set("transitiveMemberOf", value); }
        }
#nullable restore
#else
        public List<DirectoryObject> TransitiveMemberOf {
            get { return BackingStore?.Get<List<DirectoryObject>>("transitiveMemberOf"); }
            set { BackingStore?.Set("transitiveMemberOf", value); }
        }
#endif
        /// <summary>A two letter country code (ISO standard 3166). Required for users that will be assigned licenses due to legal requirement to check for availability of services in countries.  Examples include: US, JP, and GB. Not nullable. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UsageLocation {
            get { return BackingStore?.Get<string?>("usageLocation"); }
            set { BackingStore?.Set("usageLocation", value); }
        }
#nullable restore
#else
        public string UsageLocation {
            get { return BackingStore?.Get<string>("usageLocation"); }
            set { BackingStore?.Set("usageLocation", value); }
        }
#endif
        /// <summary>The user principal name (UPN) of the user. The UPN is an Internet-style login name for the user based on the Internet standard RFC 822. By convention, this should map to the user&apos;s email name. The general format is alias@domain, where domain must be present in the tenant&apos;s collection of verified domains. This property is required when a user is created. The verified domains for the tenant can be accessed from the verifiedDomains property of organization.NOTE: This property cannot contain accent characters. Only the following characters are allowed A - Z, a - z, 0 - 9, &apos; . - _ ! # ^ ~. For the complete list of allowed characters, see username policies. Returned by default. Supports $filter (eq, ne, not, ge, le, in, startsWith, endsWith) and $orderBy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName {
            get { return BackingStore?.Get<string?>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#nullable restore
#else
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#endif
        /// <summary>A string value that can be used to classify user types in your directory, such as Member and Guest. Returned only on $select. Supports $filter (eq, ne, not, in, and eq on null values). NOTE: For more information about the permissions for member and guest users, see What are the default user permissions in Azure Active Directory?</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserType {
            get { return BackingStore?.Get<string?>("userType"); }
            set { BackingStore?.Set("userType", value); }
        }
#nullable restore
#else
        public string UserType {
            get { return BackingStore?.Get<string>("userType"); }
            set { BackingStore?.Set("userType", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new User and sets the default values.
        /// </summary>
        public User() : base() {
            OdataType = "#microsoft.graph.user";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new User CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new User();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"aboutMe", n => { AboutMe = n.GetStringValue(); } },
                {"accountEnabled", n => { AccountEnabled = n.GetBoolValue(); } },
                {"activities", n => { Activities = n.GetCollectionOfObjectValues<UserActivity>(UserActivity.CreateFromDiscriminatorValue)?.ToList(); } },
                {"ageGroup", n => { AgeGroup = n.GetStringValue(); } },
                {"agreementAcceptances", n => { AgreementAcceptances = n.GetCollectionOfObjectValues<AgreementAcceptance>(AgreementAcceptance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"appRoleAssignments", n => { AppRoleAssignments = n.GetCollectionOfObjectValues<AppRoleAssignment>(AppRoleAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"assignedLicenses", n => { AssignedLicenses = n.GetCollectionOfObjectValues<AssignedLicense>(AssignedLicense.CreateFromDiscriminatorValue)?.ToList(); } },
                {"assignedPlans", n => { AssignedPlans = n.GetCollectionOfObjectValues<AssignedPlan>(AssignedPlan.CreateFromDiscriminatorValue)?.ToList(); } },
                {"authentication", n => { Authentication = n.GetObjectValue<Microsoft.Graph.Models.Authentication>(Microsoft.Graph.Models.Authentication.CreateFromDiscriminatorValue); } },
                {"authorizationInfo", n => { AuthorizationInfo = n.GetObjectValue<Microsoft.Graph.Models.AuthorizationInfo>(Microsoft.Graph.Models.AuthorizationInfo.CreateFromDiscriminatorValue); } },
                {"birthday", n => { Birthday = n.GetDateTimeOffsetValue(); } },
                {"businessPhones", n => { BusinessPhones = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"calendar", n => { Calendar = n.GetObjectValue<Microsoft.Graph.Models.Calendar>(Microsoft.Graph.Models.Calendar.CreateFromDiscriminatorValue); } },
                {"calendarGroups", n => { CalendarGroups = n.GetCollectionOfObjectValues<CalendarGroup>(CalendarGroup.CreateFromDiscriminatorValue)?.ToList(); } },
                {"calendars", n => { Calendars = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.Calendar>(Microsoft.Graph.Models.Calendar.CreateFromDiscriminatorValue)?.ToList(); } },
                {"calendarView", n => { CalendarView = n.GetCollectionOfObjectValues<Event>(Event.CreateFromDiscriminatorValue)?.ToList(); } },
                {"chats", n => { Chats = n.GetCollectionOfObjectValues<Chat>(Chat.CreateFromDiscriminatorValue)?.ToList(); } },
                {"city", n => { City = n.GetStringValue(); } },
                {"companyName", n => { CompanyName = n.GetStringValue(); } },
                {"consentProvidedForMinor", n => { ConsentProvidedForMinor = n.GetStringValue(); } },
                {"contactFolders", n => { ContactFolders = n.GetCollectionOfObjectValues<ContactFolder>(ContactFolder.CreateFromDiscriminatorValue)?.ToList(); } },
                {"contacts", n => { Contacts = n.GetCollectionOfObjectValues<Contact>(Contact.CreateFromDiscriminatorValue)?.ToList(); } },
                {"country", n => { Country = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdObjects", n => { CreatedObjects = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"creationType", n => { CreationType = n.GetStringValue(); } },
                {"department", n => { Department = n.GetStringValue(); } },
                {"deviceEnrollmentLimit", n => { DeviceEnrollmentLimit = n.GetIntValue(); } },
                {"deviceManagementTroubleshootingEvents", n => { DeviceManagementTroubleshootingEvents = n.GetCollectionOfObjectValues<DeviceManagementTroubleshootingEvent>(DeviceManagementTroubleshootingEvent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"directReports", n => { DirectReports = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"drive", n => { Drive = n.GetObjectValue<Microsoft.Graph.Models.Drive>(Microsoft.Graph.Models.Drive.CreateFromDiscriminatorValue); } },
                {"drives", n => { Drives = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.Drive>(Microsoft.Graph.Models.Drive.CreateFromDiscriminatorValue)?.ToList(); } },
                {"employeeHireDate", n => { EmployeeHireDate = n.GetDateTimeOffsetValue(); } },
                {"employeeId", n => { EmployeeId = n.GetStringValue(); } },
                {"employeeLeaveDateTime", n => { EmployeeLeaveDateTime = n.GetDateTimeOffsetValue(); } },
                {"employeeOrgData", n => { EmployeeOrgData = n.GetObjectValue<Microsoft.Graph.Models.EmployeeOrgData>(Microsoft.Graph.Models.EmployeeOrgData.CreateFromDiscriminatorValue); } },
                {"employeeType", n => { EmployeeType = n.GetStringValue(); } },
                {"events", n => { Events = n.GetCollectionOfObjectValues<Event>(Event.CreateFromDiscriminatorValue)?.ToList(); } },
                {"extensions", n => { Extensions = n.GetCollectionOfObjectValues<Extension>(Extension.CreateFromDiscriminatorValue)?.ToList(); } },
                {"externalUserState", n => { ExternalUserState = n.GetStringValue(); } },
                {"externalUserStateChangeDateTime", n => { ExternalUserStateChangeDateTime = n.GetDateTimeOffsetValue(); } },
                {"faxNumber", n => { FaxNumber = n.GetStringValue(); } },
                {"followedSites", n => { FollowedSites = n.GetCollectionOfObjectValues<Site>(Site.CreateFromDiscriminatorValue)?.ToList(); } },
                {"givenName", n => { GivenName = n.GetStringValue(); } },
                {"hireDate", n => { HireDate = n.GetDateTimeOffsetValue(); } },
                {"identities", n => { Identities = n.GetCollectionOfObjectValues<ObjectIdentity>(ObjectIdentity.CreateFromDiscriminatorValue)?.ToList(); } },
                {"imAddresses", n => { ImAddresses = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"inferenceClassification", n => { InferenceClassification = n.GetObjectValue<Microsoft.Graph.Models.InferenceClassification>(Microsoft.Graph.Models.InferenceClassification.CreateFromDiscriminatorValue); } },
                {"insights", n => { Insights = n.GetObjectValue<OfficeGraphInsights>(OfficeGraphInsights.CreateFromDiscriminatorValue); } },
                {"interests", n => { Interests = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"isResourceAccount", n => { IsResourceAccount = n.GetBoolValue(); } },
                {"jobTitle", n => { JobTitle = n.GetStringValue(); } },
                {"joinedTeams", n => { JoinedTeams = n.GetCollectionOfObjectValues<Team>(Team.CreateFromDiscriminatorValue)?.ToList(); } },
                {"lastPasswordChangeDateTime", n => { LastPasswordChangeDateTime = n.GetDateTimeOffsetValue(); } },
                {"legalAgeGroupClassification", n => { LegalAgeGroupClassification = n.GetStringValue(); } },
                {"licenseAssignmentStates", n => { LicenseAssignmentStates = n.GetCollectionOfObjectValues<LicenseAssignmentState>(LicenseAssignmentState.CreateFromDiscriminatorValue)?.ToList(); } },
                {"licenseDetails", n => { LicenseDetails = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.LicenseDetails>(Microsoft.Graph.Models.LicenseDetails.CreateFromDiscriminatorValue)?.ToList(); } },
                {"mail", n => { Mail = n.GetStringValue(); } },
                {"mailboxSettings", n => { MailboxSettings = n.GetObjectValue<Microsoft.Graph.Models.MailboxSettings>(Microsoft.Graph.Models.MailboxSettings.CreateFromDiscriminatorValue); } },
                {"mailFolders", n => { MailFolders = n.GetCollectionOfObjectValues<MailFolder>(MailFolder.CreateFromDiscriminatorValue)?.ToList(); } },
                {"mailNickname", n => { MailNickname = n.GetStringValue(); } },
                {"managedAppRegistrations", n => { ManagedAppRegistrations = n.GetCollectionOfObjectValues<ManagedAppRegistration>(ManagedAppRegistration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedDevices", n => { ManagedDevices = n.GetCollectionOfObjectValues<ManagedDevice>(ManagedDevice.CreateFromDiscriminatorValue)?.ToList(); } },
                {"manager", n => { Manager = n.GetObjectValue<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue); } },
                {"memberOf", n => { MemberOf = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"messages", n => { Messages = n.GetCollectionOfObjectValues<Message>(Message.CreateFromDiscriminatorValue)?.ToList(); } },
                {"mobilePhone", n => { MobilePhone = n.GetStringValue(); } },
                {"mySite", n => { MySite = n.GetStringValue(); } },
                {"oauth2PermissionGrants", n => { Oauth2PermissionGrants = n.GetCollectionOfObjectValues<OAuth2PermissionGrant>(OAuth2PermissionGrant.CreateFromDiscriminatorValue)?.ToList(); } },
                {"officeLocation", n => { OfficeLocation = n.GetStringValue(); } },
                {"onenote", n => { Onenote = n.GetObjectValue<Microsoft.Graph.Models.Onenote>(Microsoft.Graph.Models.Onenote.CreateFromDiscriminatorValue); } },
                {"onlineMeetings", n => { OnlineMeetings = n.GetCollectionOfObjectValues<OnlineMeeting>(OnlineMeeting.CreateFromDiscriminatorValue)?.ToList(); } },
                {"onPremisesDistinguishedName", n => { OnPremisesDistinguishedName = n.GetStringValue(); } },
                {"onPremisesDomainName", n => { OnPremisesDomainName = n.GetStringValue(); } },
                {"onPremisesExtensionAttributes", n => { OnPremisesExtensionAttributes = n.GetObjectValue<Microsoft.Graph.Models.OnPremisesExtensionAttributes>(Microsoft.Graph.Models.OnPremisesExtensionAttributes.CreateFromDiscriminatorValue); } },
                {"onPremisesImmutableId", n => { OnPremisesImmutableId = n.GetStringValue(); } },
                {"onPremisesLastSyncDateTime", n => { OnPremisesLastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"onPremisesProvisioningErrors", n => { OnPremisesProvisioningErrors = n.GetCollectionOfObjectValues<OnPremisesProvisioningError>(OnPremisesProvisioningError.CreateFromDiscriminatorValue)?.ToList(); } },
                {"onPremisesSamAccountName", n => { OnPremisesSamAccountName = n.GetStringValue(); } },
                {"onPremisesSecurityIdentifier", n => { OnPremisesSecurityIdentifier = n.GetStringValue(); } },
                {"onPremisesSyncEnabled", n => { OnPremisesSyncEnabled = n.GetBoolValue(); } },
                {"onPremisesUserPrincipalName", n => { OnPremisesUserPrincipalName = n.GetStringValue(); } },
                {"otherMails", n => { OtherMails = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"outlook", n => { Outlook = n.GetObjectValue<OutlookUser>(OutlookUser.CreateFromDiscriminatorValue); } },
                {"ownedDevices", n => { OwnedDevices = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"ownedObjects", n => { OwnedObjects = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"passwordPolicies", n => { PasswordPolicies = n.GetStringValue(); } },
                {"passwordProfile", n => { PasswordProfile = n.GetObjectValue<Microsoft.Graph.Models.PasswordProfile>(Microsoft.Graph.Models.PasswordProfile.CreateFromDiscriminatorValue); } },
                {"pastProjects", n => { PastProjects = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"people", n => { People = n.GetCollectionOfObjectValues<Person>(Person.CreateFromDiscriminatorValue)?.ToList(); } },
                {"photo", n => { Photo = n.GetObjectValue<ProfilePhoto>(ProfilePhoto.CreateFromDiscriminatorValue); } },
                {"photos", n => { Photos = n.GetCollectionOfObjectValues<ProfilePhoto>(ProfilePhoto.CreateFromDiscriminatorValue)?.ToList(); } },
                {"planner", n => { Planner = n.GetObjectValue<PlannerUser>(PlannerUser.CreateFromDiscriminatorValue); } },
                {"postalCode", n => { PostalCode = n.GetStringValue(); } },
                {"preferredDataLocation", n => { PreferredDataLocation = n.GetStringValue(); } },
                {"preferredLanguage", n => { PreferredLanguage = n.GetStringValue(); } },
                {"preferredName", n => { PreferredName = n.GetStringValue(); } },
                {"presence", n => { Presence = n.GetObjectValue<Microsoft.Graph.Models.Presence>(Microsoft.Graph.Models.Presence.CreateFromDiscriminatorValue); } },
                {"provisionedPlans", n => { ProvisionedPlans = n.GetCollectionOfObjectValues<ProvisionedPlan>(ProvisionedPlan.CreateFromDiscriminatorValue)?.ToList(); } },
                {"proxyAddresses", n => { ProxyAddresses = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"registeredDevices", n => { RegisteredDevices = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"responsibilities", n => { Responsibilities = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"schools", n => { Schools = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"scopedRoleMemberOf", n => { ScopedRoleMemberOf = n.GetCollectionOfObjectValues<ScopedRoleMembership>(ScopedRoleMembership.CreateFromDiscriminatorValue)?.ToList(); } },
                {"securityIdentifier", n => { SecurityIdentifier = n.GetStringValue(); } },
                {"settings", n => { Settings = n.GetObjectValue<UserSettings>(UserSettings.CreateFromDiscriminatorValue); } },
                {"showInAddressList", n => { ShowInAddressList = n.GetBoolValue(); } },
                {"signInSessionsValidFromDateTime", n => { SignInSessionsValidFromDateTime = n.GetDateTimeOffsetValue(); } },
                {"skills", n => { Skills = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"state", n => { State = n.GetStringValue(); } },
                {"streetAddress", n => { StreetAddress = n.GetStringValue(); } },
                {"surname", n => { Surname = n.GetStringValue(); } },
                {"teamwork", n => { Teamwork = n.GetObjectValue<UserTeamwork>(UserTeamwork.CreateFromDiscriminatorValue); } },
                {"todo", n => { Todo = n.GetObjectValue<Microsoft.Graph.Models.Todo>(Microsoft.Graph.Models.Todo.CreateFromDiscriminatorValue); } },
                {"transitiveMemberOf", n => { TransitiveMemberOf = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"usageLocation", n => { UsageLocation = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                {"userType", n => { UserType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("aboutMe", AboutMe);
            writer.WriteBoolValue("accountEnabled", AccountEnabled);
            writer.WriteCollectionOfObjectValues<UserActivity>("activities", Activities);
            writer.WriteStringValue("ageGroup", AgeGroup);
            writer.WriteCollectionOfObjectValues<AgreementAcceptance>("agreementAcceptances", AgreementAcceptances);
            writer.WriteCollectionOfObjectValues<AppRoleAssignment>("appRoleAssignments", AppRoleAssignments);
            writer.WriteCollectionOfObjectValues<AssignedLicense>("assignedLicenses", AssignedLicenses);
            writer.WriteCollectionOfObjectValues<AssignedPlan>("assignedPlans", AssignedPlans);
            writer.WriteObjectValue<Microsoft.Graph.Models.Authentication>("authentication", Authentication);
            writer.WriteObjectValue<Microsoft.Graph.Models.AuthorizationInfo>("authorizationInfo", AuthorizationInfo);
            writer.WriteDateTimeOffsetValue("birthday", Birthday);
            writer.WriteCollectionOfPrimitiveValues<string>("businessPhones", BusinessPhones);
            writer.WriteObjectValue<Microsoft.Graph.Models.Calendar>("calendar", Calendar);
            writer.WriteCollectionOfObjectValues<CalendarGroup>("calendarGroups", CalendarGroups);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.Calendar>("calendars", Calendars);
            writer.WriteCollectionOfObjectValues<Event>("calendarView", CalendarView);
            writer.WriteCollectionOfObjectValues<Chat>("chats", Chats);
            writer.WriteStringValue("city", City);
            writer.WriteStringValue("companyName", CompanyName);
            writer.WriteStringValue("consentProvidedForMinor", ConsentProvidedForMinor);
            writer.WriteCollectionOfObjectValues<ContactFolder>("contactFolders", ContactFolders);
            writer.WriteCollectionOfObjectValues<Contact>("contacts", Contacts);
            writer.WriteStringValue("country", Country);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("createdObjects", CreatedObjects);
            writer.WriteStringValue("creationType", CreationType);
            writer.WriteStringValue("department", Department);
            writer.WriteIntValue("deviceEnrollmentLimit", DeviceEnrollmentLimit);
            writer.WriteCollectionOfObjectValues<DeviceManagementTroubleshootingEvent>("deviceManagementTroubleshootingEvents", DeviceManagementTroubleshootingEvents);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("directReports", DirectReports);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<Microsoft.Graph.Models.Drive>("drive", Drive);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.Drive>("drives", Drives);
            writer.WriteDateTimeOffsetValue("employeeHireDate", EmployeeHireDate);
            writer.WriteStringValue("employeeId", EmployeeId);
            writer.WriteDateTimeOffsetValue("employeeLeaveDateTime", EmployeeLeaveDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Models.EmployeeOrgData>("employeeOrgData", EmployeeOrgData);
            writer.WriteStringValue("employeeType", EmployeeType);
            writer.WriteCollectionOfObjectValues<Event>("events", Events);
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteStringValue("externalUserState", ExternalUserState);
            writer.WriteDateTimeOffsetValue("externalUserStateChangeDateTime", ExternalUserStateChangeDateTime);
            writer.WriteStringValue("faxNumber", FaxNumber);
            writer.WriteCollectionOfObjectValues<Site>("followedSites", FollowedSites);
            writer.WriteStringValue("givenName", GivenName);
            writer.WriteDateTimeOffsetValue("hireDate", HireDate);
            writer.WriteCollectionOfObjectValues<ObjectIdentity>("identities", Identities);
            writer.WriteCollectionOfPrimitiveValues<string>("imAddresses", ImAddresses);
            writer.WriteObjectValue<Microsoft.Graph.Models.InferenceClassification>("inferenceClassification", InferenceClassification);
            writer.WriteObjectValue<OfficeGraphInsights>("insights", Insights);
            writer.WriteCollectionOfPrimitiveValues<string>("interests", Interests);
            writer.WriteBoolValue("isResourceAccount", IsResourceAccount);
            writer.WriteStringValue("jobTitle", JobTitle);
            writer.WriteCollectionOfObjectValues<Team>("joinedTeams", JoinedTeams);
            writer.WriteDateTimeOffsetValue("lastPasswordChangeDateTime", LastPasswordChangeDateTime);
            writer.WriteStringValue("legalAgeGroupClassification", LegalAgeGroupClassification);
            writer.WriteCollectionOfObjectValues<LicenseAssignmentState>("licenseAssignmentStates", LicenseAssignmentStates);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.LicenseDetails>("licenseDetails", LicenseDetails);
            writer.WriteStringValue("mail", Mail);
            writer.WriteObjectValue<Microsoft.Graph.Models.MailboxSettings>("mailboxSettings", MailboxSettings);
            writer.WriteCollectionOfObjectValues<MailFolder>("mailFolders", MailFolders);
            writer.WriteStringValue("mailNickname", MailNickname);
            writer.WriteCollectionOfObjectValues<ManagedAppRegistration>("managedAppRegistrations", ManagedAppRegistrations);
            writer.WriteCollectionOfObjectValues<ManagedDevice>("managedDevices", ManagedDevices);
            writer.WriteObjectValue<DirectoryObject>("manager", Manager);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("memberOf", MemberOf);
            writer.WriteCollectionOfObjectValues<Message>("messages", Messages);
            writer.WriteStringValue("mobilePhone", MobilePhone);
            writer.WriteStringValue("mySite", MySite);
            writer.WriteCollectionOfObjectValues<OAuth2PermissionGrant>("oauth2PermissionGrants", Oauth2PermissionGrants);
            writer.WriteStringValue("officeLocation", OfficeLocation);
            writer.WriteObjectValue<Microsoft.Graph.Models.Onenote>("onenote", Onenote);
            writer.WriteCollectionOfObjectValues<OnlineMeeting>("onlineMeetings", OnlineMeetings);
            writer.WriteStringValue("onPremisesDistinguishedName", OnPremisesDistinguishedName);
            writer.WriteStringValue("onPremisesDomainName", OnPremisesDomainName);
            writer.WriteObjectValue<Microsoft.Graph.Models.OnPremisesExtensionAttributes>("onPremisesExtensionAttributes", OnPremisesExtensionAttributes);
            writer.WriteStringValue("onPremisesImmutableId", OnPremisesImmutableId);
            writer.WriteDateTimeOffsetValue("onPremisesLastSyncDateTime", OnPremisesLastSyncDateTime);
            writer.WriteCollectionOfObjectValues<OnPremisesProvisioningError>("onPremisesProvisioningErrors", OnPremisesProvisioningErrors);
            writer.WriteStringValue("onPremisesSamAccountName", OnPremisesSamAccountName);
            writer.WriteStringValue("onPremisesSecurityIdentifier", OnPremisesSecurityIdentifier);
            writer.WriteBoolValue("onPremisesSyncEnabled", OnPremisesSyncEnabled);
            writer.WriteStringValue("onPremisesUserPrincipalName", OnPremisesUserPrincipalName);
            writer.WriteCollectionOfPrimitiveValues<string>("otherMails", OtherMails);
            writer.WriteObjectValue<OutlookUser>("outlook", Outlook);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("ownedDevices", OwnedDevices);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("ownedObjects", OwnedObjects);
            writer.WriteStringValue("passwordPolicies", PasswordPolicies);
            writer.WriteObjectValue<Microsoft.Graph.Models.PasswordProfile>("passwordProfile", PasswordProfile);
            writer.WriteCollectionOfPrimitiveValues<string>("pastProjects", PastProjects);
            writer.WriteCollectionOfObjectValues<Person>("people", People);
            writer.WriteObjectValue<ProfilePhoto>("photo", Photo);
            writer.WriteCollectionOfObjectValues<ProfilePhoto>("photos", Photos);
            writer.WriteObjectValue<PlannerUser>("planner", Planner);
            writer.WriteStringValue("postalCode", PostalCode);
            writer.WriteStringValue("preferredDataLocation", PreferredDataLocation);
            writer.WriteStringValue("preferredLanguage", PreferredLanguage);
            writer.WriteStringValue("preferredName", PreferredName);
            writer.WriteObjectValue<Microsoft.Graph.Models.Presence>("presence", Presence);
            writer.WriteCollectionOfObjectValues<ProvisionedPlan>("provisionedPlans", ProvisionedPlans);
            writer.WriteCollectionOfPrimitiveValues<string>("proxyAddresses", ProxyAddresses);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("registeredDevices", RegisteredDevices);
            writer.WriteCollectionOfPrimitiveValues<string>("responsibilities", Responsibilities);
            writer.WriteCollectionOfPrimitiveValues<string>("schools", Schools);
            writer.WriteCollectionOfObjectValues<ScopedRoleMembership>("scopedRoleMemberOf", ScopedRoleMemberOf);
            writer.WriteStringValue("securityIdentifier", SecurityIdentifier);
            writer.WriteObjectValue<UserSettings>("settings", Settings);
            writer.WriteBoolValue("showInAddressList", ShowInAddressList);
            writer.WriteDateTimeOffsetValue("signInSessionsValidFromDateTime", SignInSessionsValidFromDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("skills", Skills);
            writer.WriteStringValue("state", State);
            writer.WriteStringValue("streetAddress", StreetAddress);
            writer.WriteStringValue("surname", Surname);
            writer.WriteObjectValue<UserTeamwork>("teamwork", Teamwork);
            writer.WriteObjectValue<Microsoft.Graph.Models.Todo>("todo", Todo);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("transitiveMemberOf", TransitiveMemberOf);
            writer.WriteStringValue("usageLocation", UsageLocation);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteStringValue("userType", UserType);
        }
    }
}