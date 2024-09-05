/** 
 * Funkcja obliczająca pole koła.
 * @param {number} promien - promień koła.
 * @throws {Error} jeżeli `promien` jest mniejszy lub równy 0.
 * @returns {number} - zwraca pole koła.
 * @author Jakub Wierzejewski 5D
*/

function calculateArea(promien){
    if (promien<=0){
        throw new Error("Too low value error");
    } else{
        return Math.PI*promien^2;
    }
}