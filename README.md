**Note: Solution file available in AuthPractice folder**

**Repo Description**
##JWT Authentication System with Auth API and Auth Client (Clean Architecture)##

This project implements a JWT-based authentication system using Clean Architecture principles. It consists of two components: an Auth API for user authentication and an Auth Client app. The authentication system is stateless, utilizing JWT (JSON Web Tokens), with the token securely stored in a cookie on the client side for session persistence.
Key Features:

    Clean Architecture:
        The project follows Clean Architecture principles, ensuring separation of concerns and maintaining a clear boundary between core business logic, application services, and infrastructure.

    Auth API:
        Provides JWT-based authentication and issues tokens after successful login.
        Implements user authentication, validation, and token management in the Application and Domain layers.

    Auth Client:
        A client-side application that retrieves the JWT from the Auth API and stores it in a secure, HttpOnly cookie.
        Accesses secured resources using the JWT token, validated locally without requiring repeated calls to the Auth API.


    Login page in AuthClient app request token from Auth.API app, if the user is a valid the API returns a valid JSON Token which stored by AuthClient app and used for
    accesing a secured 'Home/Index' resource with in the client app.
