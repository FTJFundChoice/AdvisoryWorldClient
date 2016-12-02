# Unofficial AdvisoryWorld API C# Client
Unofficial client for AdvisoryWorld API

## Features
- AdvisoryWorld Authentication
- Proposal Coverage

### Dependencies
- RestSharp
- SimpleJson

### WIP
- General Request Properties (POST)
  - filtering
  - sort
  - userId

### Unit Testing
- Add App.config AdvisoryWorldClient.Test
```
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <appSettings>
    <add key="apiUrl" value="[API_URL]" />
    <add key="username" value="[API_USERNAME]" />
    <add key="password" value="[API_PASSWORD]" />
  </appSettings>
</configuration>
```
- Run all or select a specific test.
