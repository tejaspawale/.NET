namespace AccountsManager.Listners;

public interface AccountListener {
    void onUnderBalance(double balance);
    void onOverBalance(double balance);
}
