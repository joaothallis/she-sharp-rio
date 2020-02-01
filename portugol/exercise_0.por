programa {
     funcao inicio() {
        inteiro first_number
        inteiro second_number
        
        escreva("Write the first number: ")
        leia(first_number)
        escreva("Write the second number: ")
        leia(second_number)
        se(first_number>second_number)
            escreva("The greather number is: ", first_number)
        se(second_number>first_number)
            escreva("The greather number is: ", second_number)
        se(first_number==second_number)
            escreva("The numbers are equal")
     }
 }