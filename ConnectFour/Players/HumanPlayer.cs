namespace ConnectFour.Players;

public class HumanPlayer : Player
{
    public HumanPlayer(string name, char symbol)
        : base(name, symbol)
    {
    }

    public override int ChooseColumn()
    {
        // Console input logic will be implemented in a later milestone.
        return 0;
    }
}
