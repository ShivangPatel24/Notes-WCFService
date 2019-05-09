
package org.tempuri;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlElementDecl;
import javax.xml.bind.annotation.XmlRegistry;
import javax.xml.namespace.QName;
import org.datacontract.schemas._2004._07.wcfnotesapp.ArrayOfNotes;
import org.datacontract.schemas._2004._07.wcfnotesapp.Notes;


/**
 * This object contains factory methods for each 
 * Java content interface and Java element interface 
 * generated in the org.tempuri package. 
 * <p>An ObjectFactory allows you to programatically 
 * construct new instances of the Java representation 
 * for XML content. The Java representation of XML 
 * content can consist of schema derived interfaces 
 * and classes representing the binding of schema 
 * type definitions, element declarations and model 
 * groups.  Factory methods for each of these are 
 * provided in this class.
 * 
 */
@XmlRegistry
public class ObjectFactory {

    private final static QName _RegisterPass_QNAME = new QName("http://tempuri.org/", "pass");
    private final static QName _RegisterName_QNAME = new QName("http://tempuri.org/", "name");
    private final static QName _RegisterEmail_QNAME = new QName("http://tempuri.org/", "email");
    private final static QName _AddNoteDetails_QNAME = new QName("http://tempuri.org/", "details");
    private final static QName _AddNoteTitle_QNAME = new QName("http://tempuri.org/", "title");
    private final static QName _GetNotesResponseGetNotesResult_QNAME = new QName("http://tempuri.org/", "getNotesResult");
    private final static QName _GetNoteResponseGetNoteResult_QNAME = new QName("http://tempuri.org/", "getNoteResult");
    private final static QName _LoginResponseLoginResult_QNAME = new QName("http://tempuri.org/", "LoginResult");

    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: org.tempuri
     * 
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link GetNoteResponse }
     * 
     */
    public GetNoteResponse createGetNoteResponse() {
        return new GetNoteResponse();
    }

    /**
     * Create an instance of {@link LoginResponse }
     * 
     */
    public LoginResponse createLoginResponse() {
        return new LoginResponse();
    }

    /**
     * Create an instance of {@link Login }
     * 
     */
    public Login createLogin() {
        return new Login();
    }

    /**
     * Create an instance of {@link GetNote }
     * 
     */
    public GetNote createGetNote() {
        return new GetNote();
    }

    /**
     * Create an instance of {@link AddNote }
     * 
     */
    public AddNote createAddNote() {
        return new AddNote();
    }

    /**
     * Create an instance of {@link UpdateNoteResponse }
     * 
     */
    public UpdateNoteResponse createUpdateNoteResponse() {
        return new UpdateNoteResponse();
    }

    /**
     * Create an instance of {@link UpdateNote }
     * 
     */
    public UpdateNote createUpdateNote() {
        return new UpdateNote();
    }

    /**
     * Create an instance of {@link DeleteNoteResponse }
     * 
     */
    public DeleteNoteResponse createDeleteNoteResponse() {
        return new DeleteNoteResponse();
    }

    /**
     * Create an instance of {@link GetNotesResponse }
     * 
     */
    public GetNotesResponse createGetNotesResponse() {
        return new GetNotesResponse();
    }

    /**
     * Create an instance of {@link RegisterResponse }
     * 
     */
    public RegisterResponse createRegisterResponse() {
        return new RegisterResponse();
    }

    /**
     * Create an instance of {@link GetNotes }
     * 
     */
    public GetNotes createGetNotes() {
        return new GetNotes();
    }

    /**
     * Create an instance of {@link Register }
     * 
     */
    public Register createRegister() {
        return new Register();
    }

    /**
     * Create an instance of {@link DeleteNote }
     * 
     */
    public DeleteNote createDeleteNote() {
        return new DeleteNote();
    }

    /**
     * Create an instance of {@link AddNoteResponse }
     * 
     */
    public AddNoteResponse createAddNoteResponse() {
        return new AddNoteResponse();
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "pass", scope = Register.class)
    public JAXBElement<String> createRegisterPass(String value) {
        return new JAXBElement<String>(_RegisterPass_QNAME, String.class, Register.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "name", scope = Register.class)
    public JAXBElement<String> createRegisterName(String value) {
        return new JAXBElement<String>(_RegisterName_QNAME, String.class, Register.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "email", scope = Register.class)
    public JAXBElement<String> createRegisterEmail(String value) {
        return new JAXBElement<String>(_RegisterEmail_QNAME, String.class, Register.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "details", scope = AddNote.class)
    public JAXBElement<String> createAddNoteDetails(String value) {
        return new JAXBElement<String>(_AddNoteDetails_QNAME, String.class, AddNote.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "name", scope = AddNote.class)
    public JAXBElement<String> createAddNoteName(String value) {
        return new JAXBElement<String>(_RegisterName_QNAME, String.class, AddNote.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "title", scope = AddNote.class)
    public JAXBElement<String> createAddNoteTitle(String value) {
        return new JAXBElement<String>(_AddNoteTitle_QNAME, String.class, AddNote.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "pass", scope = Login.class)
    public JAXBElement<String> createLoginPass(String value) {
        return new JAXBElement<String>(_RegisterPass_QNAME, String.class, Login.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "email", scope = Login.class)
    public JAXBElement<String> createLoginEmail(String value) {
        return new JAXBElement<String>(_RegisterEmail_QNAME, String.class, Login.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "details", scope = UpdateNote.class)
    public JAXBElement<String> createUpdateNoteDetails(String value) {
        return new JAXBElement<String>(_AddNoteDetails_QNAME, String.class, UpdateNote.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "title", scope = UpdateNote.class)
    public JAXBElement<String> createUpdateNoteTitle(String value) {
        return new JAXBElement<String>(_AddNoteTitle_QNAME, String.class, UpdateNote.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ArrayOfNotes }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "getNotesResult", scope = GetNotesResponse.class)
    public JAXBElement<ArrayOfNotes> createGetNotesResponseGetNotesResult(ArrayOfNotes value) {
        return new JAXBElement<ArrayOfNotes>(_GetNotesResponseGetNotesResult_QNAME, ArrayOfNotes.class, GetNotesResponse.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link Notes }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "getNoteResult", scope = GetNoteResponse.class)
    public JAXBElement<Notes> createGetNoteResponseGetNoteResult(Notes value) {
        return new JAXBElement<Notes>(_GetNoteResponseGetNoteResult_QNAME, Notes.class, GetNoteResponse.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "name", scope = GetNotes.class)
    public JAXBElement<String> createGetNotesName(String value) {
        return new JAXBElement<String>(_RegisterName_QNAME, String.class, GetNotes.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "LoginResult", scope = LoginResponse.class)
    public JAXBElement<String> createLoginResponseLoginResult(String value) {
        return new JAXBElement<String>(_LoginResponseLoginResult_QNAME, String.class, LoginResponse.class, value);
    }

}
