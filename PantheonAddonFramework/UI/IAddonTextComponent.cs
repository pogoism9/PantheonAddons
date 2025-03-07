namespace PantheonAddonFramework.UI;

public interface IAddonTextComponent
{
    string GetText();
    void SetText(string text);
    void SetSize(float width, float height);
    void Enable(bool enabled);
    void Destroy();
}