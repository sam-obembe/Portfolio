namespace Portfolio.Utils
{
    public interface ISanityImgHelper
    {

        /// <summary>
        /// Takes the ref and generates and image url see : https://www.sanity.io/docs/image-urls
        /// </summary>
        /// <param name="imageRef">the value from _ref field e.g "_ref": "image-ea07f1715ce7d20a505de2bf52122bb438e4af53-2004x2193-jpg",</param>
        /// <returns></returns>
        public string GetImageUrl(string imageRef, int? height, int? width);
    }
}
