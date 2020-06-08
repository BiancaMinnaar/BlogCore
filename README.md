# BlogCore
A kata to demonstrate my Full-stack capabilities

1. Identify and plan DB structure
2. Code Objects first
3. Implement Entity Framework Code First for Database
4. Wrap Identified Service Calls in Error return object
5. Use Git To Track Progress

Object Identified
Blog
- ID
- Title
- Description
- CreationDate

Blog Entry
- ID
- BlogID
- HeadingText
- EntryText
- UserID
- EntryDate

User
- ID
- UserName
- CreationDate

API Calls
- AddBlog
{
    Title,
    Descrition    
}
- GetBlogEntriesSortedAsc?{BlogID}
- AddBlogEntry
{
    BlogID,
    UserID,
    EntryHeading,
    EntryText,
    UserID
}
- DeleteBlogEntry?{EntryID}
- GetUsers
- GetUserByID?{ID}
- DeleteUserByID?{ID} - DeleteEntriesByUserID?{UserID}
- AddUser
{
    userName
}

Development notes
1.Initialisation of BlogController successful on https://localhost:5001/api/Blog POST
first result: {
    "dataModel": null,
    "status": {
        "status": 200,
        "message": "Success",
        "stackTrace": null
    }
}

2. Test Blog Creation with BlogController - success with body json
 - {"Title":"The First Blog","Description":"This is to test the BlogController POST"}

3. Add And Test Create User and Return all users from userController
- https://localhost:5001/api/user POST
- {"UserName":"Bianca"}
- Result:
{
    "dataModel": null,
    "status": {
        "status": 200,
        "message": "Success",
        "stackTrace": null
    }
}
- https://localhost:5001/api/user GET
- Result:
{
    "dataModel": [
        {
            "id": "d7b3984a-31fd-4938-8c6a-efcb720f1d39",
            "userName": "Bianca",
            "creationDate": "2020-06-08T17:33:56.706391"
        }
    ],
    "status": {
        "status": 200,
        "message": "Success",
        "stackTrace": null
    }
}
