package ru.geekbrains.lesson4.contracts;

/**
 *
 */
public class Condition {
    public static boolean Check(boolean[] booleans) {
        for (boolean item : booleans) {
            if (!item) return false;
        }
        return true;
    }

    /**
     * Предусловие
     */
    public static void Precondition(boolean[] booleans) throws PreconditionException {
        if (!Check(booleans))
            throw new PreconditionException();
    }

    /**
     * Постусловие
     */
    public static void Postcondition(boolean[] booleans) throws PostconditionException {
        if (!Check(booleans))
            throw new PostconditionException();
    }

    /**
     * Инвариант
     */
    public static void Invariant(boolean[] booleans) throws Exception {
        if (!Check(booleans))
            throw new InvariantException();
    }
}

