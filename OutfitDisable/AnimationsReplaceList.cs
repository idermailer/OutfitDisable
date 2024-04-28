namespace OutfitDisable
{
    public sealed class AnimationsReplaceList
    {
        public class AnimationReplaceTarget
        {
            public readonly Dictionary<string, string>? referenceAnimations;
            public readonly Dictionary<string, string>? manualAnimations;

            public AnimationReplaceTarget(Dictionary<string, string>? referenceAnimations, Dictionary<string, string>? manualAnimations)
            {
                this.referenceAnimations = referenceAnimations;
                this.manualAnimations = manualAnimations;
            }
        }

        // Relative NPC -> animation to replace and animation to use
        public Dictionary<string, AnimationReplaceTarget> Targets { get; set; }

        public AnimationsReplaceList()
        {
            Targets = new Dictionary<string, AnimationReplaceTarget>();
        }
    }
}