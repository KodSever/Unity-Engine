// ADD PARTICLE
    
    obj.transform.position = Vector3.zero;
    ParticleSystem particleSystem = obj.AddComponent<ParticleSystem>();
    Renderer render = particleSystem.GetComponent<Renderer>();
    render.material = matDuman;
