public class Enemies{

    //Default health level of enemies
    public int health = 10;

    public int standardHealth(){
        return health;
    }

    //Fly
    public static void Fly(){}
    //Spider
    public void Spider()
    {
     Console.WriteLine("""
                          \                     /
                           \                   /
                            \                 /
                             \ ____________  /
                             \/            \/
                             [              ]
                  -----------\             /-------------
                              \           /
                               \         /
                   -------------\_______/----------------              
                                (       )
                                /\     /\
                               /  [___]  \
                              /           \
                             /             \
                            /               \
                           /                 \
    """ 
     );
    }
    //Snake
    public void Snake()
    {
     Console.WriteLine("""
                                             
                                                  -  - - - - - - - - - -
                                              -                         \
                                          -       - - - - - - - - - - -  \
                                      -        -
                                    -       -
                                   -      -
                                   -     -
                                  -      -
                                   -     -
                                   -       -
                                     -      -
                                       -       -
                                         -       -
                                            -      -
                                              -      -
                                               -       -  
                               /------\            -       -
                              /        \            \       \          
                             /         \            \        \
                            / _____     \            \       \
                            (           \            \       \
                           -     /\      \            \      \      
                          -    -   \      \           /     /
                         -    -     \      \         /     /
                        -    -       \      \       /     /
                       -    -         \      \     /     /
                        \/\/\          \      \  /     /
                         \   \          \            /
                          \   \           - - - - - -
                           (___)
                       """);
    }
    //Boss
    public void Boss(){}
}