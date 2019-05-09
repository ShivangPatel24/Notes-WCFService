/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 *
 * @author Shivang
 */
public class SignUp extends HttpServlet {

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/html;charset=UTF-8");
        String email=request.getParameter("email");
		String fnm=request.getParameter("name");
		String unm=request.getParameter("username");
		String pass=request.getParameter("pass");
		String rpass=request.getParameter("repeat-pass");
	
		if(rpass.equals(pass)||!email.equals("") || !fnm.equals("") || !unm.equals("") || !pass.equals(""))
                {
                    int res = register(email,pass,unm);
                    if(res == 1)
                    {
                        RequestDispatcher rd = request.getRequestDispatcher("/Login.jsp");
                        rd.forward(request, response);
                    }
                    if(res == 0)
                    {
			request.setAttribute("errorMessage", "User not registered");
                        RequestDispatcher rd = request.getRequestDispatcher("/SignUp.jsp");
                        rd.forward(request, response);
                    }
                }
                else if(email.equals("") || fnm.equals("") || unm.equals("") || pass.equals(""))
                    {
			request.setAttribute("errorMessage", "Fill the details");
                        RequestDispatcher rd = request.getRequestDispatcher("/SignUp.jsp");
                        rd.forward(request, response);
                    }
		
		
	}
    

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

    private static Integer register(java.lang.String email, java.lang.String pass, java.lang.String name) {
        org.tempuri.Service1 service = new org.tempuri.Service1();
        org.tempuri.IService1 port = service.getBasicHttpBindingIService1();
        return port.register(email, pass, name);
    }

   


}
