class AegonTargarean
{
    constructor()
    {
        this.VallarMorhillis = false;
    }
    tostring()
    {
        return(this.forceIsDark? 'Join' : 'All hail Targarean')+'Bow to them'
    }
}

class MotherofDragon extends AegonTargarean
{
    constructor()
    {
        super();
        this.VallarMorhillis = true;
    }
    
}