package ru.geekbrains.lesson4.contracts;

/**
 *
 */
class ContractException extends Exception {

    public ContractException(String s) {
        super(s + " Contract Exception");
    }
}
