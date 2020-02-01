programa {
    funcao inicio() {
        inteiro distance_traveled
        inteiro consumed_fuel
        inteiro average_consuption
        
        escreva("Type the distance traveled: ")
        leia(distance_traveled)
        escreva("Type the consumed fuel: ")
        leia(consumed_fuel)
        
        average_consuption = consumed_fuel / (distance_traveled / 100)
        escreva(average_consuption)
    }
}