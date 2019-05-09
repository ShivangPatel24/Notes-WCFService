<%-- 
    Document   : Update
    Created on : 5 Apr, 2019, 10:23:18 PM
    Author     : Shivang
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Update</title>
    </head>
    <body>
        <form method="POST" action="UpdateProcess">
            <input type="hidden" value="${name}" name="name"><br>
            <input type="hidden" value="${id}" name="id"><br>
            <input type="text" value="${title}" name="title"><br>
            <input type="text" value="${details}" name="details"><br>
            <input type="Submit" value="Update">
        </form>
    </body>
</html>
