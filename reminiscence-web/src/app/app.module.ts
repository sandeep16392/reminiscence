import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { AboutComponent } from './about/about.component';
import { NavigationComponent } from './navigation/navigation.component';
import { FeaturesComponent } from './features/features.component';
import { CategoriesComponent } from './categories/categories.component';
import { StoriesComponent } from './stories/stories.component';
import { RegisterComponent } from './register/register.component';
import { FooterComponent } from './footer/footer.component';
import { PopupComponent } from './popup/popup.component';
import { GalleryComponent } from './gallery/gallery.component';

import { GalleryService } from './services/gallery.service';

import { AppRoutes } from './routes';
import { LoginComponent } from './login/login.component';
import { GenresComponent } from './genres/genres.component';
@NgModule({
   declarations: [
      AppComponent,
      HeaderComponent,
      AboutComponent,
      NavigationComponent,
      FeaturesComponent,
      CategoriesComponent,
      StoriesComponent,
      RegisterComponent,
      FooterComponent,
      PopupComponent,
      GalleryComponent,
      LoginComponent,
      GenresComponent
   ],
   imports: [
      HttpClientModule,
      BrowserModule,
      RouterModule.forRoot(AppRoutes)
   ],
   providers: [
      GalleryService
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
