#version 410 core

in vec3 fragmentColor;
out vec4 color;

void main() {
  //color = vec4(fragmentColor,0.8);
  color = vec4(0,0,0,0.4);
}
