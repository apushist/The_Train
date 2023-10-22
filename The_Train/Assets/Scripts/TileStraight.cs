using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileStraight : Tile
{
    public override void StartFilling()
    {
        _tubeContent.fillOrigin = (int)Image.OriginHorizontal.Left;
        StartCoroutine(FillThis(_fillTime, _fillFrames));
    }
    public override bool CheckInputDirectionValid(Direction input)
    {
        if (inputDir == input) return true;
        else if (outputDir == input)
        {
            rotationOnce();
            rotationOnce();
            return true;
        }
        else
        {
            return false;
        }
    }
}
