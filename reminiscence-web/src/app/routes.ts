import { Routes } from '@angular/router';
import { RegisterComponent } from "./register/register.component";
import { HeaderComponent } from './header/header.component';
import { CategoriesComponent } from './categories/categories.component';

export const AppRoutes:Routes = [
    {path:'register', component: RegisterComponent},
    {path: 'home', component: HeaderComponent},
    {path: 'categories', component: CategoriesComponent},
    {path:'', redirectTo:'/home', pathMatch: 'full'}
]