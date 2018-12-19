using TMPro;
using UnityEngine;

public class AppTrackableEventHandler : DefaultTrackableEventHandler
{
    public TextMeshPro text;
    private int FoundCount { get; set; } = 0;
    private int LostCount { get; set; } = 0;

    private void Awake()
    {
        this.ShowInformation();
    }

    protected override void OnTrackingFound()
    {
        this.FoundCount++;
        this.ShowInformation();
    }

    protected override void OnTrackingLost()
    {
        this.LostCount++;
        this.ShowInformation();
    }

    private void ShowInformation()
    {
        this.text.text = $"Found: {this.FoundCount}\nLost: {this.LostCount}";
        this.text.GetComponent<Animator>()?.Play("Zoom");
    }
}
