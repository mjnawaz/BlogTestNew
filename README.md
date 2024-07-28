# Blogging Platform API

This is a simple RESTful API for managing a blogging platform, built with .NET 6 Minimal API. It allows for managing blog posts and their associated comments.

## Getting Started

### Prerequisites

- .NET 6 SDK
- Visual Studio Code or any preferred IDE that supports .NET
- PowerShell or any compatible command line tool for testing the API

### Installation

1. **Clone the repository or download the source code:**
`
   ```bash
   git clone https://github.com/mjnawaz/BlogTestNew.git
   cd BloggingPlatform

2. **Build the project to restore dependencies:**

	dotnet build
 ##To start the server, run:
	dotnet run

API Endpoints
The API supports the following endpoints:

##GET /api/posts

Description: Retrieves all blog posts.
Example request: Invoke-RestMethod http://localhost:5189/api/posts -Method Get

##POST /api/posts

Description: Creates a new blog post.
Example request: 
$url = "http://localhost:5189/api/posts"
$jsonBody = '{"title": "My First Post", "content": "This is my first blog post."}'
Invoke-RestMethod -Uri $url -Method Post -ContentType 'application/json' -Body $jsonBody

##GET /api/posts/{id}

Description: Retrieves a specific blog post by ID.
Example request: Invoke-RestMethod http://localhost:5189/api/posts/1 -Method Get

##POST /api/posts/{id}/comments

Description: Adds a new comment to a specific blog post.
Example request:$url = "http://localhost:5189/api/posts/1/comments"
$jsonBody = '{"content": "Great post! Thanks for sharing."}'
Invoke-RestMethod -Uri $url -Method Post -ContentType 'application/json' -Body $jsonBody



##Testing the API
You can test the API using PowerShell with Invoke-RestMethod as shown in the example requests above, or use any API testing tool such as Postman.
