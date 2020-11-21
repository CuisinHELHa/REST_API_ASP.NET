﻿using System;
using System.Data.SqlClient;
using CuisinHELHa.DAO;

namespace CuisinHELHa.DTO
{
    public class RecipesDTO
    {
        public int IdRecipe { get; set; }
        public int IdUser { get; set; }
        public string NameRecipe { get; set; }
        public DateTime PostDate { get; set; }
        public string Summary { get; set; }
        public int Persons { get; set; }
        public int PrepTime { get; set; }
        public int SpiceRate { get; set; }
        public string RecipeType { get; set; }

        public RecipesDTO(int idRecipe, int idUser, string nameRecipe, DateTime postDate, string summary, int persons, int prepTime, int spiceRate, string recipeType)
        {
            this.IdRecipe = idRecipe;
            IdUser = idUser;
            NameRecipe = nameRecipe;
            PostDate = postDate;
            Summary = summary;
            Persons = persons;
            PrepTime = prepTime;
            SpiceRate = spiceRate;
            RecipeType = recipeType;
        }

        public RecipesDTO()
        {
        }

        public RecipesDTO(SqlDataReader reader)
        {
            IdRecipe = Convert.ToInt32(reader[RecipesDAO.FIELD_ID_RECIPE].ToString());
            IdUser = Convert.ToInt32(reader[RecipesDAO.FIELD_ID_USER].ToString()) ;
            NameRecipe = reader[RecipesDAO.FIELD_NAME_RECIPE].ToString();
            String postDate = reader[RecipesDAO.FIELD_POSTDATE].ToString();
            Summary = reader[RecipesDAO.FIELD_SUMMARY].ToString();
            PostDate = Convert.ToDateTime(reader[RecipesDAO.FIELD_POSTDATE].ToString());
            Persons = Convert.ToInt32(reader[RecipesDAO.FIELD_PERSONS].ToString());
            PrepTime = Convert.ToInt32(reader[RecipesDAO.FIELD_PREPTIME].ToString());
            SpiceRate = Convert.ToInt32(reader[RecipesDAO.FIELD_SPICES_RATE].ToString());
            RecipeType = reader[RecipesDAO.FIELD_RECIPE_TYPE].ToString();
            
        }
    }
}