Shader "GD3/StandardDiffuse" {

	Properties{
		_Color("Color", Color) = (1,1,1,1)
		_MainTex("Albedo (RGB)", 2D) = "white" {}
	_Glossiness("Smoothness", Range(0,1)) = 0.5
		_Metallic("Metallic", Range(0,1)) = 0.0
		_Amount("Extrusion Amount", Range(-1,1)) = 0
	}

		SubShader{

		Tags{ "RenderType" = "Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Lambert vertex:vert

#pragma target 3.0

		fixed4 _Color; 
	sampler2D _MainTex;
	half _Glossiness; 
	half _Metallic;
	float _Amount;

	struct Input {
		float2 uv_MainTex; 
	};
	void Update() {
	}
	void vert(inout appdata_full v) {
		v.vertex.xyz += v.normal * _Amount;
	}

	void surf(Input IN, inout SurfaceOutput o) {

		fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;

		o.Albedo = c.rgb;

		o.Alpha = c.a;
	}
	ENDCG
	}
		FallBack "Diffuse"
}