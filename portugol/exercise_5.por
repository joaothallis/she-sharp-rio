programa {
    funcao inicio() {
        cadeia student_name
        inteiro test_grade_1
        inteiro test_grade_2
        inteiro test_grade_3
        
        leia(student_name)
        leia(test_grade_1)
        leia(test_grade_2)
        leia(test_grade_3)
        
        escreva("Student name: ", student_name)
        escreva("\n")
        escreva("Arithmetic average: ", (test_grade_1 + test_grade_2 + test_grade_3) / 3)
    }
}