using Leopotam.EcsLite;

namespace Client {
    sealed class InitSystem : IEcsInitSystem {
        private readonly EcsWorld _world;
        public void Init (IEcsSystems systems) {
            int entity = _world.NewEntity();
        }
    }
}