# ToDoList-MVC

----
STEP1: Create a new postgresql database with parameters Database=postgres; Username=postgres; Password=test123

STEP1.1: Change the parameters in appsettings.json with your own config;

STEP2: RUN Add-Migration in the packet manager

STEP3: RUN Update-Database in the packet manager

STEP4: RUN IIS or just start

STEP5: REGISTER or you won't have access to any api
Example http://localhost:24288/api/v1/Authentication/signup
:{
  "username": "eric",
  "email": "eric@hotmail.com",
  "password": "ericthedevil123*",
  "createdTime": "string"
}

Email needs to be valid and passwords needs to contain 1 capital, 8 characters and 1 special character

STEP6: LOGIN 
Example: http://localhost:24288/api/v1/Authentication/signin
:{
  "username": "eric",
  "password": "ericthedevil123*",
}

Returns a JWT token, copy it. Use postman to save the token, in Postman go to authorization, change type to bearer token and paste in the JWT token.

STEP7: Create a new item, in postman click on body, check the radio button raw instead of none and change the text format to JSON.
Make sure to insert a new itemID and a itemNam and a new id. Username and normalizedUserName needs to the same.

EXAMPLE: http://localhost:24288/api/v1/ToDoItem
{
  "itemId": 10,
  "itemName": "Book",
  "itemDescription": "new",
  "itemStatus": "onUpdated",
  "itemCreated": "string",
  "itemUpdated": "string",
  "user": {
    "id": "10",
    "userName": "eric",
    "normalizedUserName": "eric",
    "email": "string",
    "normalizedEmail": "string",
    "emailConfirmed": true,
    "passwordHash": "string",
    "securityStamp": "string",
    "concurrencyStamp": "string",
    "phoneNumber": "string",
    "phoneNumberConfirmed": true,
    "twoFactorEnabled": true,
    "lockoutEnd": "2022-02-10T22:45:47.444Z",
    "lockoutEnabled": true,
    "accessFailedCount": 0,
    "userCreated": "string",
    "userUpdated": "string"
  }
}

STEP8: GET AN ITEM BY ID
EXAMPLE  http://localhost:24288/api/ToDoItem/10
returns an ToDoItem

STEP9: CHANGE AN ITEM ItemUpdated will update the moment you change it
EXAMPLE:http://localhost:24288/api/ToDoItem/10
{
  "itemId": 10,
  "itemName": "Book1",
  "itemDescription": "old",
  "itemStatus": "onUpdated",
  "itemCreated": "string",
  "itemUpdated": "string",
  "user": {
    "id": "10",
    "userName": "eric1",
    "normalizedUserName": "eric1",
    "email": "string",
    "normalizedEmail": "string",
    "emailConfirmed": true,
    "passwordHash": "string",
    "securityStamp": "string",
    "concurrencyStamp": "string",
    "phoneNumber": "string",
    "phoneNumberConfirmed": true,
    "twoFactorEnabled": true,
    "lockoutEnd": "2022-02-10T22:45:47.444Z",
    "lockoutEnabled": true,
    "accessFailedCount": 0,
    "userCreated": "string",
    "userUpdated": "string"
  }
}

STEP10: DELETE AN ITEM BASED ON ID
EXAMPLE http://localhost:24288/api/ToDoItem/10

STEP11: GET ITEM BASED ON STATUS
EXAMPLE http://localhost:24288/api/v1/ToDoItem/status=onUpdated




