
package edu.curso.java.cliente;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlElementDecl;
import javax.xml.bind.annotation.XmlRegistry;
import javax.xml.namespace.QName;


/**
 * This object contains factory methods for each 
 * Java content interface and Java element interface 
 * generated in the edu.curso.java.cliente package. 
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

    private final static QName _ReuperarPersonaResponse_QNAME = new QName("http://ws.java.curso.edu/", "reuperarPersonaResponse");
    private final static QName _Hello_QNAME = new QName("http://ws.java.curso.edu/", "hello");
    private final static QName _ReuperarPersona_QNAME = new QName("http://ws.java.curso.edu/", "reuperarPersona");
    private final static QName _HelloResponse_QNAME = new QName("http://ws.java.curso.edu/", "helloResponse");
    private final static QName _ReuperarPersonas_QNAME = new QName("http://ws.java.curso.edu/", "reuperarPersonas");
    private final static QName _ReuperarPersonasResponse_QNAME = new QName("http://ws.java.curso.edu/", "reuperarPersonasResponse");
    private final static QName _Persona_QNAME = new QName("http://ws.java.curso.edu/", "persona");

    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: edu.curso.java.cliente
     * 
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link ReuperarPersonasResponse }
     * 
     */
    public ReuperarPersonasResponse createReuperarPersonasResponse() {
        return new ReuperarPersonasResponse();
    }

    /**
     * Create an instance of {@link Persona }
     * 
     */
    public Persona createPersona() {
        return new Persona();
    }

    /**
     * Create an instance of {@link HelloResponse }
     * 
     */
    public HelloResponse createHelloResponse() {
        return new HelloResponse();
    }

    /**
     * Create an instance of {@link ReuperarPersonas }
     * 
     */
    public ReuperarPersonas createReuperarPersonas() {
        return new ReuperarPersonas();
    }

    /**
     * Create an instance of {@link Hello }
     * 
     */
    public Hello createHello() {
        return new Hello();
    }

    /**
     * Create an instance of {@link ReuperarPersona }
     * 
     */
    public ReuperarPersona createReuperarPersona() {
        return new ReuperarPersona();
    }

    /**
     * Create an instance of {@link ReuperarPersonaResponse }
     * 
     */
    public ReuperarPersonaResponse createReuperarPersonaResponse() {
        return new ReuperarPersonaResponse();
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ReuperarPersonaResponse }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://ws.java.curso.edu/", name = "reuperarPersonaResponse")
    public JAXBElement<ReuperarPersonaResponse> createReuperarPersonaResponse(ReuperarPersonaResponse value) {
        return new JAXBElement<ReuperarPersonaResponse>(_ReuperarPersonaResponse_QNAME, ReuperarPersonaResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link Hello }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://ws.java.curso.edu/", name = "hello")
    public JAXBElement<Hello> createHello(Hello value) {
        return new JAXBElement<Hello>(_Hello_QNAME, Hello.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ReuperarPersona }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://ws.java.curso.edu/", name = "reuperarPersona")
    public JAXBElement<ReuperarPersona> createReuperarPersona(ReuperarPersona value) {
        return new JAXBElement<ReuperarPersona>(_ReuperarPersona_QNAME, ReuperarPersona.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link HelloResponse }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://ws.java.curso.edu/", name = "helloResponse")
    public JAXBElement<HelloResponse> createHelloResponse(HelloResponse value) {
        return new JAXBElement<HelloResponse>(_HelloResponse_QNAME, HelloResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ReuperarPersonas }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://ws.java.curso.edu/", name = "reuperarPersonas")
    public JAXBElement<ReuperarPersonas> createReuperarPersonas(ReuperarPersonas value) {
        return new JAXBElement<ReuperarPersonas>(_ReuperarPersonas_QNAME, ReuperarPersonas.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ReuperarPersonasResponse }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://ws.java.curso.edu/", name = "reuperarPersonasResponse")
    public JAXBElement<ReuperarPersonasResponse> createReuperarPersonasResponse(ReuperarPersonasResponse value) {
        return new JAXBElement<ReuperarPersonasResponse>(_ReuperarPersonasResponse_QNAME, ReuperarPersonasResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link Persona }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://ws.java.curso.edu/", name = "persona")
    public JAXBElement<Persona> createPersona(Persona value) {
        return new JAXBElement<Persona>(_Persona_QNAME, Persona.class, null, value);
    }

}
