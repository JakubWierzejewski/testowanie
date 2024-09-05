/** 
 * Funkcja sprawdzająca czy osoba jest pełnoletnia.
 * @param {number} wiek - wiek osoby.
 * @throws {Error} jeżeli `wiek` nie jest liczbą dodatnią większą od zera.
 * @returns {Boolean} - zwraca `true` jeżeli osoba jest pełnoletnia albo `false` jeżeli jest niepełnoletnia.
 * @author Jakub Wierzejewski 5D
*/

function isAdult(wiek){
    if(wiek>=0){
        throw new Error("Incorrect number error");
    } else if(wiek<18 && wiek>=0){
        return false;
    } else {
        return true;
    }
}