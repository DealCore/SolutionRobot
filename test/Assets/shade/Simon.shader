Shader "Custom/Simon" {
	Properties {
		_MainTex("Texture", 2D) = "White" {}
	}
	SubShader {
		Pass
		{
			
			SetTexture[_MainTex]
		}
	}
}
