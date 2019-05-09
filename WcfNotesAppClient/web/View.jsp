<%-- 
    Document   : View
    Created on : 6 Apr, 2019, 6:35:16 PM
    Author     : Shivang
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>${title}</title>
    </head>
    <body>
        <h1>${title}</h1>
        <br>
        ${details}<br>
        <form method="POST" action="ViewProcess">
            <input type="hidden" value="${name}" name="name"><br>
            <input type="Submit" value="Back">
            </form>
    </body>
</html>
