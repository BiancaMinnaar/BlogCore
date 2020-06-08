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
Initialisation of BlogController successful on https://localhost:5001/api/Blog POST
first result: {
    "dataModel": null,
    "status": {
        "status": 200,
        "message": "Success",
        "stackTrace": null
    }
}
