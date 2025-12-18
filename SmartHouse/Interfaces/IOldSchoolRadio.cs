namespace SmartHouse.Interfaces;

public interface IOldSchoolRadio
{
    void PowerOn();
    void PowerOff();
    void SetVolume(int volume);
}