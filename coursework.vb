Module Module1

    Sub Main()

        Console.Title = "CS0002"

        Menu() 'user picks an option from the menu and is taken to correspnding screen


        Console.ReadLine()
    End Sub

    Sub Menu()


        Dim selection As Char

        While selection <> "6" 'until user chooses 6 to exit, user chooses another option from menu to progress



            Console.WriteLine("CS0002 COURSEWORK")
            Console.WriteLine("-----------------------")
            Console.WriteLine("")


            Console.WriteLine("(1) Accuracy Option")
            Console.WriteLine("(2) Quadratic equation")
            Console.WriteLine("(3) Protein Sequence Segmentation")
            Console.WriteLine("(4) Prime Decision")
            Console.WriteLine("(5) Help")
            Console.WriteLine("(6) Exit")

            Console.WriteLine("Please choose an option from 1-6 and press enter")


            selection = Console.ReadLine 'user inputs a number to go to selected option

            Dim y As Integer 'variable for the accuracy option the user will choose
            Dim d As Integer 'variable to return to menu 

            If selection = "1" Then
                Console.WriteLine("You have selected Accuracy Option") 'allows user to select a decimal place and applies it where neccessary
                Console.WriteLine("Please input the number of decimal places, 1-5:")
                y = Console.ReadLine
                Console.WriteLine("Enter 1 to return to the menu")
                d = Console.ReadLine()
                If d = 1 Then
                    Console.Clear()
                    If d <> 1 Then
                        Console.WriteLine("Option no valid") 'user must choose 1 otherwise error will occur
                    End If
                End If
            ElseIf selection = "2" Then
                Quadraticequation(y) 'takes the value of y from above which user has inputted and takes it to quadratic equation sub 
            ElseIf selection = "3" Then
                ProteinSequenceSegmentation() 'takes user to protein sequence segmentation sub
            ElseIf selection = "4" Then
                PrimeDecision() 'takes user to primedecision sub
            ElseIf selection = "5" Then
                Help() 'take user to help sub
            End If

        End While

    End Sub




    Sub Quadraticequation(y As Integer) 'parameter set to y so value of y in menu is brought into this sub and used when finding roots
        Console.WriteLine("You have selected Quadratic Equation")

        Dim root1 As Double, root2 As Double, a As Double, b As Double, c As Double, d As Integer
        Console.WriteLine("input a non zero, a=")
        a = Console.ReadLine
        Console.WriteLine("input a value, b=")
        b = Console.ReadLine
        Console.WriteLine("input a value, c=")  'user inputs 3 values, a, b, and c
        c = Console.ReadLine

        root1 = (-b + Sqrt(Abs((b ^ 2) - 4 * a * c))) / (2 * a)
        root2 = (-b - Sqrt(Abs((b ^ 2) - 4 * a * c))) / (2 * a) 'both roots are solved 

        If (Sqrt(Abs((b ^ 2) - 4 * a * c))) < 0 Then
            Console.WriteLine("error, negative numbers cannot be sqaure rooted") 'if discriminant is < 0, error will occur

        End If


        Console.WriteLine("the roots of this quadratic equaton are:")
        Console.WriteLine(Math.Round(root1, y))
        Console.WriteLine(Math.Round(root2, y)) 'decimal place applied by user will be applied when roots are displayed


        Console.WriteLine("Enter 1 to return to the menu") 'returns user to menu via if statements
        d = Console.ReadLine()
        If d = 1 Then
            Console.Clear()
            If d <> 1 Then
                Console.WriteLine("Option no valid")
            End If
        End If


    End Sub






    Sub ProteinSequenceSegmentation()
        Console.WriteLine("You have selected Protein Seqeunce Segmentation")
        Dim protein As String = "GLSDGEWQQVLNVWGKVEADIAGHGQEVLIRLFTGHPETLEKFDKFKHLKTEAEMKASEDLKKHGTVVLTALGGILKKKGHHEAELKPLAQSHATKHKIPIKYLEFISDAIIHVLHSKHPGDFGADAQGAMTKALELFRNDIAAKYKELGFQG" 'this protein is declared and will be segmented

        Dim subst As String = protein.Substring(0, 16) 'substring declared as a copy of the protein strng but cut from position a to b . the same has been for the entire protein as seen below
        Console.WriteLine(subst)

        Dim subst2 As String = protein.Substring(16, 15)
        Console.WriteLine(subst2)

        Dim subst3 As String = protein.Substring(31, 11)
        Console.WriteLine(subst3)

        Dim subst4 As String = protein.Substring(42, 3)
        Console.WriteLine(subst4)

        Dim subst5 As String = protein.Substring(45, 2)
        Console.WriteLine(subst5)

        Dim subst6 As String = protein.Substring(47, 3)
        Console.WriteLine(subst6)

        Dim subst7 As String = protein.Substring(50, 6)
        Console.WriteLine(subst7)

        Dim subst8 As String = protein.Substring(56, 6)
        Console.WriteLine(subst8)

        Dim subst9 As String = protein.Substring(62, 1)
        Console.WriteLine(subst9)

        Dim subst10 As String = protein.Substring(63, 14)
        Console.WriteLine(subst10)

        Dim subst11 As String = protein.Substring(77, 1)
        Console.WriteLine(subst11)

        Dim subst12 As String = protein.Substring(78, 1)
        Console.WriteLine(subst12)

        Dim subst13 As String = protein.Substring(79, 17)
        Console.WriteLine(subst13)

        Dim subst14 As String = protein.Substring(96, 2)
        Console.WriteLine(subst14)

        Dim subst15 As String = protein.Substring(98, 4)
        Console.WriteLine(subst15)

        Dim subst16 As String = protein.Substring(102, 16)
        Console.WriteLine(subst16)

        Dim subst17 As String = protein.Substring(118, 15)
        Console.WriteLine(subst17)

        Dim subst18 As String = protein.Substring(133, 6)
        Console.WriteLine(subst18)

        Dim subst19 As String = protein.Substring(139, 6)
        Console.WriteLine(subst19)

        Dim subst20 As String = protein.Substring(145, 2)
        Console.WriteLine(subst20)

        Dim subst21 As String = protein.Substring(147, 6) 'protein has finished segmentation
        Console.WriteLine(subst21)

        Dim d As Integer 'rteurns user back to menu
        Console.WriteLine("Enter 1 to return to the menu")
        d = Console.ReadLine()
        If d = 1 Then
            Console.Clear()
            If d <> 1 Then
                Console.WriteLine("Option no valid")
            End If
        End If

    End Sub





    Sub PrimeDecision()
        Console.WriteLine("You have selected Prime Decision")



        Dim x As Long, i As Long, d As Integer
        Console.WriteLine("Please input a positive integer")
        x = Console.ReadLine 'the user inputs their positive integer

        Dim StartTime As Double, EndTime As Double 'declare timers
        StartTime = Timer 'name the starttime variable

        For i = 2 To x - 1
            If x Mod i = 0 Then 'the for and if statements divide the number entered by i which keeps increasing, starting at 2 and ending at the number entered -1. if the remainder is 0, then x = 0 which results in number not being prime as it is divisible by a number 
                x = 0           'other than itself and 1. if is not 0 so it has a remainder when divided by another number, then it is a prime
                Exit For
            End If
        Next

        If x = 0 Then
            Console.WriteLine(" is not prime")
        Else
            Console.WriteLine(" is a prime")

        End If

        EndTime = Timer
        Console.WriteLine(EndTime - StartTime & "seconds spent") 'timer is made by finding difference between endtime and starttime

        Console.WriteLine("Enter 1 to return to the menu") 'returns user back to menu
        d = Console.ReadLine()
        If d = 1 Then
            Console.Clear()
            If d <> 1 Then
                Console.WriteLine("Option no valid")
            End If
        End If



    End Sub




    Sub Help()
        Console.WriteLine("You have selected Help")
        Console.WriteLine("Question: Quadratic equation comes up with error")
        Console.WriteLine("Answer: error will only come up if the discriminant is < 0 as you cannot square root a negative number")




        Dim d As Integer
        Console.WriteLine("Enter 1 to return to the menu") 'returns user to menu via if statements
        d = Console.ReadLine()
        If d = 1 Then
            Console.Clear()
            If d <> 1 Then
                Console.WriteLine("Option no valid")
            End If
        End If

    End Sub











End Module
