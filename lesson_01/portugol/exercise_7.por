programa {
    funcao inicio() {
        inteiro temperature_in_celcius 
        inteiro temperature_in_fahrenheit
        
        leia(temperature_in_celcius)
        temperature_in_fahrenheit = (9 * temperature_in_celcius + 160) / 5
        
        escreva(temperature_in_fahrenheit)
    }
}