Shader "Custom/MetaballShader" {
	Properties {
		_Color("Color", Color) = (1,1,1,1)
	}

	SubShader {
		Tags{ "RenderType" = "Opaque" }

		Cull Off

		CGPROGRAM

		#pragma surface surf Lambert

		float4 _Color;

		struct Input {
			float4 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutput o) {
			o.Emission = _Color.rgb;
		}

		ENDCG
	}

	FallBack "Diffuse"
}