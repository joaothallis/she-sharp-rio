programa {
    funcao inicio() {
        real first_number
        real second_number
        
        real sum
        real subtraction
        real multiplication
        real division
        
        escreva("Type the fist number: ")
        leia(first_number)
        escreva("Type the second number: ")
        leia(second_number)
        
        sum = first_number + second_number
        subtraction = first_number - second_number
        multiplication = first_number * second_number
        division = first_number / second_number
        
        escreva("Sum: ", sum)
        escreva("\n")
        escreva("Subtraction: ", subtraction)
        escreva("\n")
        escreva("Multiplication: ", multiplication)
        escreva("\n")
        escreva("Division: ", division)
    }
}
