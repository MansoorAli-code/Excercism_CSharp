static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if(knightIsAwake){
            return false;
        }
        return true;
    }

    public static bool CanSpy(bool k, bool a, bool p)
    {
        if(k||a||p){
            return true;
        }
        return false;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if(archerIsAwake==false && prisonerIsAwake==true){
            return true;
        }
        return false;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if((petDogIsPresent==true && archerIsAwake==false) || (prisonerIsAwake==true && archerIsAwake==false && knightIsAwake==false)){
            return true;
        }
        return false;
    }
}
