using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*************************************************************************/
/* Program Name:     Ch10Ex3.cs                                          */
/* Date:             04/20/2022                                      	 */
/* Programmer:       Miranda Morris                                      */
/* Class:            CSCI 234                               		     */
/*                                                                       */
/* Program Description: The purpose of this program is to create a       */
/* rectangle object using the user's inputted length & width. Then the   */
/* program uses these inputs to calculate the perimeter and area of the  */
/* rectangle which is then outputted in the console.                     */
/*                                                                       */
/* Input:	length, width 							                     */
/*                                                                       */
/* Output:	perimeter in the format {0:F2}                               */
/*          area in the format {1:F2}                                    */
/*		    (they are both floating numbers with 2 decimal places)       */
/*		    an exception error message if the inputted length or width   */
/*		    are out of range			                                 */
/*                                                                       */
/* Givens: None 								                         */
/*                                                                       */
/* Testing Data:                                                         */
/*                                                                       */
/* List the Testing Input:                                               */
/*			Rectangle rect = new Rectangle (12.4f, 16.5f);               */
/*			Rectangle rect = new Rectangle();                            */
/*			Rectangle rect = new Rectangle(2,3);                         */
/*			Rectangle rect = new Rectangle(10,0);                        */
/*			Rectangle rect = new Rectangle(4,22);	                     */
/*                                                                       */
/* List the Testing Output:                                              */ 
/*			Perimeter is 57.8 and the Area is 204.60                     */
/*			Perimeter is 4.00 and the Area is 1.00			             */
/*          Perimeter is 10.00 and the Area is 6.00         		     */
/*          Throws the argument out of range exception                   */
/*			Throws the argument out of range exception     		         */
/*									                                     */
/*************************************************************************/


namespace ch10ex3
{
    class Rectangle
    {
        private float length; // creates the private length
        private float width; // creates the private width

        public Rectangle(float length = 1, float width = 1) //these lengths & widths are not the same as the above ones, also sets the default to 1 for both
        {
            Length = length; //assigns the Length property to our default
            Width = width; //assigns the Wdith property to our default
        }
        public float Length //creating properties to access the length
        {
            get //tells the program to get a value that is specfied in the next line (default length)
            {
                return this.length; //the .this tells the code that we are referring to the private length (default) not the public one
            }
            set //makes sure the value is not less than 0 or more than 20
            {
                if (value <= 0.0f || value > 20.0f) //the f makes sure that it is a float, also || means or in the code

                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Length)} has to be within 1-20");

                else
                    this.length = value; //if the value is in the range then it will equal that value
            }
        }
        public float Width //creating properties to access the width
        {
            get //tells the program to get a value that is specfied in the next line (default width)
            {
                return this.width; //.this is used to let the program know we are talking about the private width
            }
            set //makes sure the value is not less than 0 or more than 20
            {
                if (value <= 0.0f || value > 20.0f) //the f makes sure that it is a float, also || means or in the code

                    throw new ArgumentOutOfRangeException(nameof(value),
                    value, $"{nameof(Width)} has to be within 1-20");

                else
                    this.width = value; //if the value is in the range then it will equal that value
            }
        }

        public float Perimeter //will be read-only which means it only has get property not set
        {
            get
            {
                return (Length + Width) * 2;  //this uses the length & width through their properties rather than their defautls
            }
        }

        public float Area //will be read-only as well which means it only has get property
        {
            get
            {
                return (Length * Width); //this also uses the length & width through their properties rather than their defaults
            }
        }

        public override string ToString() //creates a string that prints out the specified items in the next line
        {
            return string.Format("Perimeter is {0:F2} and the Area is {1:F2}", Perimeter, Area); //Prints out the Perimeter and Area, also the :F2 means a float with two decimals
        }

    }
}

