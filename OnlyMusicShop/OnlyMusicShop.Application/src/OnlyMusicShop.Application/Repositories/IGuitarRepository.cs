﻿using OnlyMusicShop.Domain.Entities;

namespace OnlyMusicShop.Application.Repositories;

public interface IGuitarRepository
{
    public List<Guitar> GetGuitars();
}