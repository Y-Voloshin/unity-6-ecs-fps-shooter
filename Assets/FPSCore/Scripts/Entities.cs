using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace FPSCore
{
    // Компонент для игрока
    public struct PlayerTag : IComponentData {}

    // Компонент здоровья
    public struct Health : IComponentData
    {
        public float Value;
        public float MaxValue;
    }

    // Компонент движения
    public struct Movement : IComponentData
    {
        public float Speed;
        public float3 Velocity;
        public bool IsGrounded;
    }

    // Компонент для прыжка
    public struct Jump : IComponentData
    {
        public float Force;
        public bool IsJumping;
    }

    // Компонент оружия
    public struct Weapon : IComponentData
    {
        public Entity WeaponEntity;
        public float FireRate;
        public float Damage;
        public float LastFireTime;
        public bool IsShooting;
    }

    // Компонент для перезагрузки игры
    public struct GameRestart : IComponentData
    {
        public bool RequestRestart;
    }

    // Компонент для ввода игрока
    public struct PlayerInput : IComponentData
    {
        public float2 Move;
        public bool Jump;
        public bool Shoot;
    }
}