package ru.geekbrains.lesson4.contracts;

/**
 * Предусловие
 */
public class PreconditionException extends ContractException {
    public PreconditionException() {
        super("Precondition");
    }
}
