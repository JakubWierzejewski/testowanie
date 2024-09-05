/** 
 * Funkcja dzielenia dwóch liczb.
 * @param {number} dzielna - pierwsza wartość.
 * @param {number} dzielnik - druga wartość.
 * @throws {Error} jeżeli `dzielnik` jest równy 0
 * @returns {number} - zwraca wynik dzielenia
 * 
 * @example
 * const a = 4;
 * const b = 2;
 * 
 * const wynik = divideNumbers(a,b);
 * console.log(wynik);
 * //Zwraca: 2
 * 
 * @author Jakub Wierzejewski 5D
*/

function divideNumbers(dzielna, dzielnik){
    if (dzielnik == 0){
        throw new Error("Divide by zero error")
    } else {
        return dzielna/dzielnik;
    }
}