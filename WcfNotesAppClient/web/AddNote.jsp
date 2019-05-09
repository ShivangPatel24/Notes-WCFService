<%-- 
    Document   : AddNote
    Created on : 4 Apr, 2019, 9:30:34 PM
    Author     : Shivang
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Add Note</title>
    </head>
    <body>
        <form method="POST" action="AddNoteProcess">
            <br>
            <input type="hidden" value="${name}" name="uname"><br>
            Title: <input type="text" name="title"><br>
            Details: <input type="text" name="details"><br>
            <input type="Submit" value="Add">
        </form>
    </body>
</html>
