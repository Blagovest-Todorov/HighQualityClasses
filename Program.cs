using System;

namespace HighQualityClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // High quality class, to do only one thing , only one aim,-strong cohesion is this. 
            // coupling--how one class depends on other class or module., not to have a things hidden communicate, 
            // minumum dependance of one class to another, coupling depended-> interface to interface is allowed, class to class dependacies is not allowed, 
            // We want to print, but we cant,  because we need internet-thats a bad example  strong oupling!
            // into the loose coupling--we can see the dependacies to other classes, loose-coupling- the HHD -We just disconnect the two cable, 
            // we put other  HDD and it works !, so we to have small, visible dependan cies is ok.
            // absraction hepls us to keep the coupling low !, interfaces help us to keep the coupling loose
            // polimorhism-help us to reuse the common logics and the common logics to be   exposed in a base class only !
            // all virtual methods we can override them !
            // polimorhism--an object to reuse some things form the parrent class !
            // class name should answer to its content/ one class one purpose !
             // group related methods intp one class !
             // a class should hide its implementation Detatils ! it is called Encapsulation --
             // we realize it per : private, internal, protected, public!
             // We have two realtions between the classes--one  is has a, another is is a ?
             // if we dont want a class to be inhereted -----we put  a sealed keyword !!!
             // more than 5-6 inheritances of classes it not needed we to have .
             // inheritance - >  the child class must resuse or extend the base class methods, dont breakt the base class logic , You extend it !
             // type cheking it very wrong situation- > use classessand inheritance !
             // is and as operators must be minimum at our code , ie type checking must be limited !
             // base class  is written m an he does not know who inherites him and how to use him!
             // top reason to create a Class : 
             // 1. -> We have a real object we want to use into our system !
             // 2 .We have abstract object\s, processes--example send emails, 
             // 3.reduce complexity , to Hide Complexity !
             // 4 Encapsulation -we want to hide some implementation!
             //5 .Avoid duplicating the data ! 
             // typical mistaket to avoid ! -0 >  Dont create plural fo class ie - >  publuc class Teachers{} / Dont !!!
             // better class Teacher {}
             // Dont throw exceptions withou concrete messages !
             // Constructors dont validate the data ! , its not the job of constructors !!!
             // always use the keyword this. to access class members witin a class !
             // use null, when a field vlaue is missing, not 0 or "" !
             // keep fields well capsulated !




        }
    }
}
