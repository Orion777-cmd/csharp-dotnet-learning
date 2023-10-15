using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args){
            //building a resilent application that are impervious to exceptions
            //data mismatch, unresolved references, network issues, etc( compilation errors)
            //runtime errors are exceptions that occur during the execution of the program
            //exceptions are objects that are thrown by the CLR when an error occurs

            
            try{
                string content = File.ReadAllText();
                Console.WriteLine(content);

            }catch(FileNotFoundException ex){
                Console.WriteLine("There was a problem");
                Console.WriteLine("Make sure the name of the file is named correctly: log.txt");
            }catch(DirectoryNotFoundException ex){
                Console.WriteLine("There was a problem");
                Console.WriteLine("Make sure the directory exists");
            }
            catch(Exception ex){
                Console.WriteLine("There was a problem");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }finally{
                //perform clean up code
                //closing database connections, closing files, etc
                Console.WriteLine("Closing application now...");
            }

        }
    }
}