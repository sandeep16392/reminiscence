import { Routes } from '@angular/router';
import { RegisterComponent } from "./register/register.component";
import { HeaderComponent } from './header/header.component';
import { CategoriesComponent } from './categories/categories.component';
import { LoginComponent } from './login/login.component';

export const AppRoutes:Routes = [
    {path:'register', component: RegisterComponent},
    {path:'login', component: LoginComponent},
    {path: '', component: HeaderComponent},
    {path: 'categories', component: CategoriesComponent},
    { path: '**', redirectTo: '', pathMatch: 'full' }
]