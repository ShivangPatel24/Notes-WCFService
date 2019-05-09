<%@page import="org.datacontract.schemas._2004._07.wcfnotesapp.Notes"%>
<%@page import="org.datacontract.schemas._2004._07.wcfnotesapp.ArrayOfNotes"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@page import="java.util.ArrayList"%>
<%@page import="java.util.List"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Home</title>
    </head>
    <body>
        <h1>Hello, ${name}</h1>
        <form method="POST" action="AddNote">
            <input type="hidden" value="${name}" name="uname"><br>
            <input type="Submit" value="Add">
        </form>
        <form method="POST" action="Logout">
            <input type="hidden" value="${name}" name="uname">
            <input type="Submit" value="Logout">
        </form><br><br>
        
        <% List<Notes> notes = (List<Notes>)request.getAttribute("notes");
        if(notes != null){
            for(Notes note : notes)
            {
                out.print(note.getTitle().getValue());
                %>
                <form method="POST" action="View">
                    <input type="hidden" value="${name}" name="name">
                    <input type="hidden" value="<% out.print(note.getId());%>" name="id">
                    <input type="submit" value="View">
                </form>
                <form method="POST" action="Update">
                    <input type="hidden" value="${name}" name="name">
                    <input type="hidden" value="<% out.print(note.getId());%>" name="id">
                    <input type="submit" value="Update">
                </form>
                <form method="POST" action="Delete">
                    <input type="hidden" value="${name}" name="name">
                    <input type="hidden" value="<% out.print(note.getId());%>" name="id">
                    <input type="submit" value="Delete">
                </form>
                <%
                
        
                out.print("<br/>");
                out.print("<br/>");
            }  
        }
        else{
            out.print("Enter a note");
        }
    
 
%>
    </body>
</html>
