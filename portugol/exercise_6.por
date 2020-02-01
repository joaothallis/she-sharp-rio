programa {
    funcao inicio() {
        inteiro a
        inteiro b
        inteiro a_backup
        
        leia(a)
        leia(b)
        
        a_backup = a
        a = b
        b = a_backup
        
        escreva(a)
        escreva("\n")
        escreva(b)
    }
}