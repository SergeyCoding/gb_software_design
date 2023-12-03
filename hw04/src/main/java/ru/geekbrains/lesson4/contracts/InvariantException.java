package ru.geekbrains.lesson4.contracts;

/**
 * Инвариант
 */
public class InvariantException extends ContractException {

    public InvariantException() {
        super("Invariant");
    }
}
