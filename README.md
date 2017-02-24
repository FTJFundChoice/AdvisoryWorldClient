# Unofficial AdvisoryWorld API C# Client
Unofficial client for AdvisoryWorld API

- Please note this is in an Alpha, unstable release. 

## Features
- AdvisoryWorld Authentication
- Proposal Coverage
  - /proposal/list
- User Management Coverage
  - /users/themes
  - /user security

### Dependencies
- System.Het.Http
- AutoMapper
- NewtonSoft Json

### Unit Testing
- Add App.config AdvisoryWorldClient.Test
```
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <appSettings>
    <add key="apiUrl" value="[API_URL]" />
    <add key="username" value="[API_USERNAME]" />
    <add key="password" value="[API_PASSWORD]" />
	<add key="Name" value="[Name]"/>
    <add key="UserId" value="[UserId]"/>
    <add key="Value" value="[Value]"/>
    <add key="UserCredentialId" value="[UserCredentialId]"/>
  </appSettings>
</configuration>
```
- Run all or select a specific test.
