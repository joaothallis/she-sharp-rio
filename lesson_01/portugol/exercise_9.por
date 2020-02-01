programa {
    funcao inicio() {
        inteiro value_deposited
        inteiro value_with_yield
        inteiro interest_in_percentage
        inteiro interest
        
        interest_in_percentage = 1
        
        leia(value_deposited)
        
        value_with_yield = value_deposited + (value_deposited * interest_in_percentage / 100)
        escreva(value_with_yield)
    }
}