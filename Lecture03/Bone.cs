
namespace Lecture03
{
    public class Bone : IBuryable
    {
        public Bone(string boneType)
        {
            BoneType = boneType;
        }

        public string BoneType { get; set; }

        public override string ToString()
        {
            return $"{BoneType} bone";
        }
    }
}
