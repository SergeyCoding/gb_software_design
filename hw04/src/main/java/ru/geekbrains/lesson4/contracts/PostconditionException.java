package ru.geekbrains.lesson4.contracts;

/**
 * Постусловие
 */
public class PostconditionException extends ContractException {
    public PostconditionException() {
        super("Postcondition");
    }
}
